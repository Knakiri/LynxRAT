namespace Quasar.Server.Forms
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
            this.Chatlog = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.RichTextBox();
            this.Sendpacket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chatlog
            // 
            this.Chatlog.Location = new System.Drawing.Point(12, 30);
            this.Chatlog.Name = "Chatlog";
            this.Chatlog.ReadOnly = true;
            this.Chatlog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Chatlog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.Chatlog.Size = new System.Drawing.Size(694, 312);
            this.Chatlog.TabIndex = 0;
            this.Chatlog.Text = "";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(12, 348);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(694, 126);
            this.message.TabIndex = 1;
            this.message.Text = "";
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
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
            this.ClientSize = new System.Drawing.Size(718, 510);
            this.Controls.Add(this.Sendpacket);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Chatlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRemoteChat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRemoteChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRemoteChat_FormClosing);
            this.Load += new System.EventHandler(this.FrmRemoteChat_Load);
            this.Shown += new System.EventHandler(this.FrmRemoteChat_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Chatlog;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Button Sendpacket;
    }
}