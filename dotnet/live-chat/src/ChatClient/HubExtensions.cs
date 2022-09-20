using Chat.Commands.Core;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatClient
{
    public static class HubExtensions
    {

        public static async Task InvokeCommandAsync(this HubConnection hub, ServerCommand serverCommand)
        {
            await hub.InvokeAsync(serverCommand.CommandName, serverCommand);
        }
    }
}
