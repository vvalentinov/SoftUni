namespace _01._Command_Pattern
{
    using _01._Command_Pattern.Core.Contracts;
    using _01._Command_Pattern.Core.Models;

    public class Program
    {
        static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}