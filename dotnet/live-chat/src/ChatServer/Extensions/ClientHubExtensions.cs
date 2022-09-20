using Chat.Commands.Core;
using Microsoft.AspNetCore.SignalR;

namespace ChatServer.Extensions
{
    public static class ClientHubExtensions
    {

        public static async Task SendCommandAsync(this IClientProxy proxy, BaseCommand command)
        {
            await proxy.SendAsync(command.CommandName, command);
        }
    }
}
