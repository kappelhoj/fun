using Chat.Commands.ClientCommands;

namespace ChatServer.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ReceiveMessageCommand receiveMessageCommand);
    }
}
