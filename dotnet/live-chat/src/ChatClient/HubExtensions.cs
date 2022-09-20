using Chat.Commands.Core;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatClient
{
    public static class HubExtensions
    {
        //TODO: Wrap On command if possible
        public static async Task InvokeCommandAsync(this HubConnection hub, ServerCommand serverCommand)
        {
            await hub.InvokeAsync(serverCommand.CommandName, serverCommand);
        }
    }
}
