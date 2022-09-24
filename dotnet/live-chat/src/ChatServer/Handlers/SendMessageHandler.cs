using Chat.Commands.ClientCommands;
using Chat.Commands.ServerCommands;
using ChatServer.Clients;

namespace ChatServer.Handlers
{
    public class SendMessageHandler
    {
        private readonly ClientBroadcaster _broadcaster;

        public SendMessageHandler(ClientBroadcaster broadcaster)
        {
            _broadcaster = broadcaster;
        }

        public async Task HandleAsync(SendMessageCommand command)
        {
            Console.WriteLine($"Message received from '{command.Username}': {command.Text}");

            var receiveMessageCommand = new ReceiveMessageCommand
            {
                Text = command.Text,
                Username = command.Username,
                TimeStamp = DateTimeOffset.Now
            };

            await _broadcaster.BroadCast(receiveMessageCommand);
        }
    }
}
