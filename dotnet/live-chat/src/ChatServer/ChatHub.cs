using Microsoft.AspNetCore.SignalR;

namespace ChatServer
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine($"Message received from '{user}': {message}");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
