using Chat.Core;
using Chat.Core.ClientCommands;
using Chat.Core.ServerCommands;
using Microsoft.AspNetCore.SignalR;

namespace ChatServer
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(SendMessageCommand messageCommand)
        {
            Console.WriteLine($"Message received from '{messageCommand.Username}': {messageCommand.Text}");

            var command = new ReceiveMessageCommand
            {
                Text = messageCommand.Text,
                Username = messageCommand.Username,
                TimeStamp = DateTimeOffset.Now
            };

            await Clients.All.SendAsync(ClientCommand.ReceiveMessage.ToString(), command);
        }
    }
}
