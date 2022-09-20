namespace Chat.Core.ClientCommands
{
    public class ReceiveMessageCommand
    {
        public string Username { get; set; }
        public string Text { get; set; }
        public DateTimeOffset TimeStamp { get; set;}
    }
}
