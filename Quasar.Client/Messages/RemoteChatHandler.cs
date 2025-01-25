using Quasar.Common.Messages;
using Quasar.Common.Networking;
using System.Threading;
using System.Windows.Forms;

namespace Quasar.Client.Messages
{
    public class RemoteChatHandler : IMessageProcessor
    {
        private static Thread _chatThread;
        private static bool _chatThreadRunning;

        public bool CanExecute(IMessage message) => message is DoChat || message is DoKillChatForm || message is DoStartChatForm;

        public bool CanExecuteFrom(ISender sender) => true;

        public void Execute(ISender sender, IMessage message)
        {
            switch (message)
            {
                case DoChat Msg:
                    HandleDoChatMessage(sender, Msg);
                    break;
                case DoStartChatForm Msg:
                    HandleDoChatStart(sender, Msg);
                    break;
                case DoKillChatForm Msg:
                    HandleDoChatStop(sender, Msg);
                    break;
            }
        }

        public static void HandleDoChatStart(ISender client, DoStartChatForm getChat)
        {
            // If a thread is already running, ignore the start request
            if (_chatThread != null && _chatThread.IsAlive)
                return;

            _chatThreadRunning = true;
            _chatThread = new Thread(() =>
            {
                var frmChat = new Client.FrmRemoteChat(client);
                Application.Run(frmChat);
            });
            _chatThread.SetApartmentState(ApartmentState.STA); // Ensure the thread runs in STA for Windows Forms
            _chatThread.Start();
        }

        public static void HandleDoChatMessage(ISender client, DoChat packet)
        {
            var frmChat = (Client.FrmRemoteChat)Application.OpenForms["FrmRemoteChat"];
            if (frmChat != null)
            {
                frmChat.Invoke((MethodInvoker)delegate
                {
                    frmChat.AddMessage("Him", packet.PacketDms);
                });
            }
        }

        public static void HandleDoChatStop(ISender client, DoKillChatForm packet)
        {
            if (_chatThread != null && _chatThread.IsAlive)
            {
                _chatThreadRunning = false;
                var frmChat = (Client.FrmRemoteChat)Application.OpenForms["FrmRemoteChat"];
                if (frmChat != null)
                {
                    frmChat.Invoke((MethodInvoker)delegate
                    {
                        frmChat.Active = false;
                        frmChat.Close();
                    });
                }

                // Wait for the thread to terminate
                _chatThread.Join(500); // Optional timeout
                _chatThread = null;
            }
        }
    }
}
