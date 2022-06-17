namespace _01._Command_Pattern.Core.Models
{
    using _01._Command_Pattern.Core.Contracts;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                string result = this.commandInterpreter.Read(command);
                if (result == null)
                {
                    break;
                }
                Console.WriteLine(result);
            }
        }
    }
}
