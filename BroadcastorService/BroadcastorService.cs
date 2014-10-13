using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BroadcastorService
{
     [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class BroadcastorService : IBroadcastorService
    {
        private static Dictionary<string, IBroadcastorCallBack> clients =
                new Dictionary<string, IBroadcastorCallBack>();
        private static object locker = new object();

        public void RegisterClient(string clientName)
        {
            if (clientName != null && clientName != "")
            {
                try
                {
                    IBroadcastorCallBack callback =
                        OperationContext.Current.GetCallbackChannel<IBroadcastorCallBack>();
                    lock (locker)
                    {
                        //remove the old client
                        if (clients.Keys.Contains(clientName))
                        {
                            clients.Remove(clientName);
                            Trace.WriteLine("removed client " + clientName);
                        }
                        clients.Add(clientName, callback);
                        Trace.WriteLine("added client " + clientName);
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(string.Format("Exception! {0}",ex));
                }
            }
        }

        public void NotifyServer(EventDataType eventData)
        {
            lock (locker)
            {
                var inactiveClients = new List<string>();
                foreach (var client in clients)
                {
                   // if (client.Key != eventData.ClientName)
                    {
                        try
                        {
                            client.Value.BroadcastToClient(eventData);
                            Trace.WriteLine("notified client " + client.Key+" with message "+eventData.EventMessage+" from "+eventData.ClientName);
                        }
                        catch (Exception ex)
                        {
                            Trace.WriteLine("remmoved client " + client.Key + " because of error "+ex.Message);
                            inactiveClients.Add(client.Key);
                        }
                    }
                }

                if (inactiveClients.Count > 0)
                {
                    foreach (var client in inactiveClients)
                    {
                        clients.Remove(client);
                    }
                }
            }
        }
     }
}
