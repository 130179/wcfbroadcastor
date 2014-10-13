using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroadcastorClient
{
    public partial class Form1 : Form
    {

        #region "callback services"
        
        public class BroadcastorCallback : BroadcastorService.IBroadcastorServiceCallback
        {
            private System.Threading.SynchronizationContext syncContext = AsyncOperationManager.SynchronizationContext;

            private EventHandler _broadcastorCallBackHandler;
            public void SetHandler(EventHandler handler)
            {
                this._broadcastorCallBackHandler = handler;
            }

            public void BroadcastToClient(BroadcastorService.EventDataType eventData)
            {
                syncContext.Post(new System.Threading.SendOrPostCallback(OnBroadcast), eventData);
            }

            private void OnBroadcast(object eventData)
            {
                this._broadcastorCallBackHandler.Invoke(eventData, null);
            }
        }

        private delegate void HandleBroadcastCallback(object sender, EventArgs e);
        public void HandleBroadcast(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new HandleBroadcastCallback(HandleBroadcast), sender, e);
            }
            else
            {
                try
                {
                    var eventData = (BroadcastorService.EventDataType)sender;
                    if (this.txtEventMessages.Text != "")
                        this.txtEventMessages.Text += "\r\n";
                    this.txtEventMessages.Text += string.Format("{0} (from {1})", 
                        eventData.EventMessage, eventData.ClientName);
                }
                catch (Exception ex)
                {
                }
            }
        }

        #endregion

        private BroadcastorService.BroadcastorServiceClient _client;

        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterClient()
        {
            if ((this._client != null))
            {
                this._client.Abort();
                this._client = null;
            }

            BroadcastorCallback cb = new BroadcastorCallback();
            cb.SetHandler(this.HandleBroadcast);

            System.ServiceModel.InstanceContext context = 
                new System.ServiceModel.InstanceContext(cb);
            this._client = 
                new BroadcastorService.BroadcastorServiceClient(context);

            this._client.RegisterClient(this.txtClientName.Text);
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            if (this.txtClientName.Text == "")
            {
                MessageBox.Show(this, "Client Name cannot be empty");
                return;
            }
            this.RegisterClient();
        }

        private void btnSendEvent_Click(object sender, EventArgs e)
        {
            if (this._client == null)
            {
                MessageBox.Show(this, "Client is not registered");
                return;
            }

            if (this.txtEventMessage.Text == "")
            {
                MessageBox.Show(this, "Cannot broadcast an empty message");
                return;
            }

            this._client.NotifyServer(
                new BroadcastorService.EventDataType()
                {
                    ClientName = this.txtClientName.Text,
                    EventMessage = this.txtEventMessage.Text
                });
        }
    }



}
