using Chat.Commands.ClientCommands;
using Chat.Commands.ServerCommands;
using ChatServer.Extensions;
using ChatServer.Handlers;
using Microsoft.AspNetCore.SignalR;

namespace ChatServer
{
    public class ChatHub : Hub<IChatClient>
    {
        private readonly SendMessageHandler _sendMessageHandler;

        public ChatHub(SendMessageHandler sendMessageHandler)
        {
            _sendMessageHandler = sendMessageHandler;
        }

        public async Task SendMessage(SendMessageCommand messageCommand) 
            => await _sendMessageHandler.HandleAsync(messageCommand);
    }
}
