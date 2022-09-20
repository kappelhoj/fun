using Chat.Commands.Core;

namespace Chat.Commands.ServerCommands
{
    public sealed class SendMessageCommand : ServerCommand
    {
        public SendMessageCommand() : base(ServerCommandTypes.Sendmessage)
        {
        }

        public string Username { get; set; }
        public string Text { get; set; }
    }
}
