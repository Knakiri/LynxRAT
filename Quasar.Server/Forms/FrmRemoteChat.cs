using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using Mono.Cecil.Cil;
using Quasar.Common.Messages;
using Quasar.Common.Models;
using Quasar.Server.Helper;
using Quasar.Server.Messages;
using Quasar.Server.Models;
using Quasar.Server.Networking;


namespace Quasar.Server.Forms
{
    public partial class FrmRemoteChat : Form
    {
        private readonly Client _connectClient;

        private readonly RemoteChatHandler chatHandler;
        private static readonly Dictionary<Client, FrmRemoteChat> OpenedForms = new Dictionary<Client, FrmRemoteChat>();

        public static FrmRemoteChat CreateNewOrGetExisting(Client client)
        {
            if (OpenedForms.ContainsKey(client))
            {
                return OpenedForms[client];
            }
            FrmRemoteChat r = new FrmRemoteChat(client);
            r.Disposed += (sender, args) => OpenedForms.Remove(client);
            OpenedForms.Add(client, r);
            return r;
        }

        private void ClientDisconnected(Client client, bool connected)
        {
            if (!connected)
            {
                this.Invoke((MethodInvoker)this.Close);
            }
        }
        public FrmRemoteChat(Client client)
        {
            _connectClient = client;
            chatHandler = new RemoteChatHandler(client);
            RegisterMessageHandler();
            InitializeComponent();
            message.KeyDown += new KeyEventHandler(message_KeyDown); // Subscribe to the KeyDown event
        }


        private void RegisterMessageHandler()
        {
            _connectClient.ClientState += ClientDisconnected;
            chatHandler.PacketsRetrieved += AddMessageClient;
            MessageHandler.Register(chatHandler);
        }

        /// <summary>
        /// Unregisters the password recovery message handler.
        /// </summary>
        private void UnregisterMessageHandler()
        {
            MessageHandler.Unregister(chatHandler);
            chatHandler.PacketsRetrieved -= AddMessageClient;
            _connectClient.ClientState -= ClientDisconnected;
        }

        private void FrmRemoteChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatHandler.KillForm();
            UnregisterMessageHandler();
        }
        public void AddMessageClient(object sender, string message)
        {
            Chatlog.Invoke((MethodInvoker)delegate
            {
                Chatlog.AppendText(string.Format("{0} {1}: {2}{3}", DateTime.Now.ToString("HH:mm:ss"), "Victim", message, Environment.NewLine));
            });
        }
        public void AddMessageServer(object sender, string message)
        {
            Chatlog.Invoke((MethodInvoker)delegate
            {
                Chatlog.AppendText(string.Format("{0} {1}: {2}{3}", DateTime.Now.ToString("HH:mm:ss"), sender, message, Environment.NewLine));
            });
        }

        private void Sendpacket_Click(object sender, EventArgs e)
        {
            if (message.Text.Trim() != "")
            {

                chatHandler.SendMessageClient(message.Text.Trim());

                AddMessageServer("Me", message.Text.Trim());
                message.Text = "";
            }
        }

        private void FrmRemoteChat_Load(object sender, EventArgs e)
        {

            this.Text = WindowHelper.GetWindowTitle("Remote Chat | ", _connectClient);
        }

        private void FrmRemoteChat_Shown(object sender, EventArgs e)
        {
            chatHandler.StartForm();
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the ding sound on pressing enter
                Sendpacket_Click(this, new EventArgs()); // Call the Send method
            }
        }
    }
}
