namespace BroadcastorClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEventMessages = new System.Windows.Forms.TextBox();
            this.lblEventMessages = new System.Windows.Forms.Label();
            this.btnSendEvent = new System.Windows.Forms.Button();
            this.txtEventMessage = new System.Windows.Forms.TextBox();
            this.lblEventMessage = new System.Windows.Forms.Label();
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEventMessages
            // 
            this.txtEventMessages.Location = new System.Drawing.Point(2, 168);
            this.txtEventMessages.Multiline = true;
            this.txtEventMessages.Name = "txtEventMessages";
            this.txtEventMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEventMessages.Size = new System.Drawing.Size(194, 130);
            this.txtEventMessages.TabIndex = 15;
            // 
            // lblEventMessages
            // 
            this.lblEventMessages.AutoSize = true;
            this.lblEventMessages.Location = new System.Drawing.Point(5, 152);
            this.lblEventMessages.Name = "lblEventMessages";
            this.lblEventMessages.Size = new System.Drawing.Size(138, 13);
            this.lblEventMessages.TabIndex = 14;
            this.lblEventMessages.Text = "Messages from other clients";
            // 
            // btnSendEvent
            // 
            this.btnSendEvent.Location = new System.Drawing.Point(20, 117);
            this.btnSendEvent.Name = "btnSendEvent";
            this.btnSendEvent.Size = new System.Drawing.Size(123, 23);
            this.btnSendEvent.TabIndex = 13;
            this.btnSendEvent.Text = "Send Event";
            this.btnSendEvent.UseVisualStyleBackColor = true;
            this.btnSendEvent.Click += new System.EventHandler(this.btnSendEvent_Click);
            // 
            // txtEventMessage
            // 
            this.txtEventMessage.Location = new System.Drawing.Point(2, 91);
            this.txtEventMessage.Name = "txtEventMessage";
            this.txtEventMessage.Size = new System.Drawing.Size(194, 20);
            this.txtEventMessage.TabIndex = 12;
            // 
            // lblEventMessage
            // 
            this.lblEventMessage.AutoSize = true;
            this.lblEventMessage.Location = new System.Drawing.Point(2, 75);
            this.lblEventMessage.Name = "lblEventMessage";
            this.lblEventMessage.Size = new System.Drawing.Size(81, 13);
            this.lblEventMessage.TabIndex = 11;
            this.lblEventMessage.Text = "Event Message";
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Location = new System.Drawing.Point(20, 44);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(123, 23);
            this.btnRegisterClient.TabIndex = 10;
            this.btnRegisterClient.Text = "Register Client";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(2, 2);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 13);
            this.lblClientName.TabIndex = 9;
            this.lblClientName.Text = "Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(2, 18);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(194, 20);
            this.txtClientName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 311);
            this.Controls.Add(this.txtEventMessages);
            this.Controls.Add(this.lblEventMessages);
            this.Controls.Add(this.btnSendEvent);
            this.Controls.Add(this.txtEventMessage);
            this.Controls.Add(this.lblEventMessage);
            this.Controls.Add(this.btnRegisterClient);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtClientName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEventMessages;
        private System.Windows.Forms.Label lblEventMessages;
        private System.Windows.Forms.Button btnSendEvent;
        private System.Windows.Forms.TextBox txtEventMessage;
        private System.Windows.Forms.Label lblEventMessage;
        private System.Windows.Forms.Button btnRegisterClient;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;

    }
}

