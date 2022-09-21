using System.Data;

namespace Chat.Commands.Core
{
    public abstract class Command
    {
        public string GetCommandName()
        {
            Type commandType = GetType();

            return GetCommandName(commandType);
        }

        public static string GetCommandName<T>()
        {
            Type commandType = typeof(T);

            if (!commandType.IsAssignableTo(typeof(Command)))
            {
                throw new ArgumentException($"Type {commandType.Name} does not inherit from Command");
            };

            return GetCommandName(commandType);
        }

        private static string GetCommandName(Type type)
        {
            // type is assignable from command.
            var commandTypeName = type.Name;

            if (!commandTypeName.EndsWith("Command"))
            {
                throw new NotSupportedException($"Type {type.Name} must end with Command to be supported");
            };

            return commandTypeName.Remove(commandTypeName.Length - "Command".Length);
        }
    }
}
