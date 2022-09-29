using Chat.Commands.Core;
using Microsoft.AspNetCore.SignalR.Client;

namespace Chat.Client
{
    public static class HubExtensions
    {
        public static IDisposable OnCommand<T>(this HubConnection hub, Action<T> action) where T : ClientCommand
        {
            return hub.On(Command.GetCommandName<T>(), action);
        }

        public static async Task InvokeCommandAsync(this HubConnection hub, ServerCommand serverCommand)
        {
            await hub.InvokeAsync(serverCommand.GetCommandName(), serverCommand);
        }
    }
}
