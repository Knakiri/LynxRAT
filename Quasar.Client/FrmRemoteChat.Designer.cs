namespace Quasar.Client
{
    partial class FrmRemoteChat
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
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.Sendpacket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(12, 30);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtMessages.Size = new System.Drawing.Size(694, 312);
            this.txtMessages.TabIndex = 0;
            this.txtMessages.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 348);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(694, 126);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // Sendpacket
            // 
            this.Sendpacket.Location = new System.Drawing.Point(631, 480);
            this.Sendpacket.Name = "Sendpacket";
            this.Sendpacket.Size = new System.Drawing.Size(75, 23);
            this.Sendpacket.TabIndex = 2;
            this.Sendpacket.Text = "Send!";
            this.Sendpacket.UseVisualStyleBackColor = true;
            this.Sendpacket.Click += new System.EventHandler(this.Sendpacket_Click);
            // 
            // FrmRemoteChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 500);
            this.ControlBox = false;
            this.Controls.Add(this.Sendpacket);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRemoteChat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Chat | Client";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmRemoteChat_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button Sendpacket;
    }
}