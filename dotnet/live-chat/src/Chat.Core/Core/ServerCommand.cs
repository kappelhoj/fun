namespace Chat.Commands.Core
{
    public abstract class ServerCommand : BaseCommand
    {
        public ServerCommand(ServerCommandTypes commandName) : base(commandName.ToString())
        {
        }
    }
}
