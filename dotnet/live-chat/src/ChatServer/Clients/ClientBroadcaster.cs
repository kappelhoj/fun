using Chat.Commands.ClientCommands;
using Microsoft.AspNetCore.SignalR;

namespace ChatServer.Clients
{
    public interface IClientBroadcaster
    {
        public Task BroadCast(ReceiveMessageCommand command);
    }

    public class ClientBroadcaster : IClientBroadcaster
    {
        private readonly IHubContext<ChatHub, IChatClient> _hubContext;

        public ClientBroadcaster(IHubContext<ChatHub, IChatClient> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task BroadCast(ReceiveMessageCommand command)
        {
            await _hubContext.Clients.All.ReceiveMessage(command);
        }
    }
}
