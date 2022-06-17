namespace _01._Command_Pattern.Core.Models
{
    using _01._Command_Pattern.Core.Contracts;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string _commandSuffix = "Command";
        public string Read(string args)
        {
            
            string[] tokens = args.Split();
            string commandName = tokens[0];
            string[] commandArgs = tokens[1..];
            //ICommand command = default;
            //if (commandName == "Hello")
            //{
            //    command = new HelloCommand();
            //}
            //else if (commandName == "Exit")
            //{
            //    command = new ExitCommand();
            //}
            //TODO: Check for Null Reference Exception
            Type commandType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == $"{commandName}{_commandSuffix}");
            ICommand command = (ICommand)Activator.CreateInstance(commandType);
            string result = command.Execute(commandArgs);
            return result;
        }
    }
}
