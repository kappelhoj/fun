namespace Chat.Commands.ServerCommands
{
    public class SendMessageCommand : BaseCommand
    {
        public string Username { get; set; }
        public string Text { get; set; }

        public override string CommandName()
        {
            return ServerCommand.Sendmessage.ToString();
        }
    }
}
