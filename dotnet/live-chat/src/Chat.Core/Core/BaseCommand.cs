namespace Chat.Commands.Core
{
    public abstract class BaseCommand
    {
        public string CommandName { get; private set; }

        public BaseCommand(string commandName)
        {
            CommandName = commandName;
        }
    }
}
