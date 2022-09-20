namespace Chat.Commands.ClientCommands
{
    public class ReceiveMessageCommand : BaseCommand
    {
        public string Username { get; set; }
        public string Text { get; set; }
        public DateTimeOffset TimeStamp { get; set; }

        public override string CommandName()
        {
            return ClientCommand.ReceiveMessage.ToString();
        }
    }
}
