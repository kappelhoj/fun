using Chat.Commands.ClientCommands;

namespace ChatServer
{
        public interface IChatClient
        {
            Task ReceiveMessage(ReceiveMessageCommand receiveMessageCommand);
        }
}
