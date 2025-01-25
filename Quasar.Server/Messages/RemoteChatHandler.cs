using Quasar.Common.Messages;
using Quasar.Common.Models;
using Quasar.Common.Networking;
using Quasar.Server.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quasar.Server.Messages
{

    public class RemoteChatHandler : MessageProcessorBase<object>
    {

        private readonly Client _client;


        public delegate void RetrievedMessageHandler(object sender, string Message);

        public event RetrievedMessageHandler PacketsRetrieved;


        private void RetrieveClientMessage(string Message)
        {
            SynchronizationContext.Post(d =>
            {
                var handler = PacketsRetrieved;
                handler?.Invoke(this, (string)d);
            }, Message);
        }
        public RemoteChatHandler(Client clients) : base(true)
        {
            _client = clients;
        }

        /// <inheritdoc />
        public override bool CanExecute(IMessage message) => message is GetChat;

        /// <inheritdoc />
        public override bool CanExecuteFrom(ISender sender) => _client.Equals(sender);
        public override void Execute(ISender sender, IMessage message)
        {
            switch (message)
            {
                case GetChat pass:
                    Execute(sender, pass);
                    break;
            }
        }
        public void StartForm()
        {

            _client.Send(new DoStartChatForm());
        }
        public void KillForm()
        {
            _client.Send(new DoKillChatForm());
        }

        public void SendMessageClient(string message)
        {
            _client.Send(new DoChat { PacketDms = message});
        }

        private void Execute(ISender client, GetChat message)
        {
            Client c = (Client)client;
            RetrieveClientMessage(message.Message);
        }
    }
}
