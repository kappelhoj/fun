using Chat.Commands.Core;

namespace Chat.Commands.ClientCommands
{
    public sealed class ReceiveMessageCommand : ClientCommand
    {
        public ReceiveMessageCommand() : base(ClientCommandTypes.ReceiveMessage)
        {
        }

        public string Username { get; set; }
        public string Text { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}
