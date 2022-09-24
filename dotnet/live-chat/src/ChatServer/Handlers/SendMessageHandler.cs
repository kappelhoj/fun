using Chat.Commands.ClientCommands;
using Chat.Commands.ServerCommands;
using Microsoft.AspNetCore.SignalR;

namespace ChatServer.Handlers
{

    public class SendMessageHandler
    {
        //TODO: Extract chat commands into seperate class?
        private readonly IHubContext<ChatHub, IChatClient> _hubContext;

        public SendMessageHandler(IHubContext<ChatHub, IChatClient> hubContext)
        {
            _hubContext = hubContext;
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

            await _hubContext.Clients.All.ReceiveMessage(receiveMessageCommand);
        }
    }
}
