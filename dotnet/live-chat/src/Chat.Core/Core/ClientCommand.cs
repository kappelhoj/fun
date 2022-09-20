namespace Chat.Commands.Core
{
    public abstract class ClientCommand : BaseCommand
    {
        public ClientCommand(ClientCommandTypes commandName) : base(commandName.ToString())
        {
        }
    }
}
