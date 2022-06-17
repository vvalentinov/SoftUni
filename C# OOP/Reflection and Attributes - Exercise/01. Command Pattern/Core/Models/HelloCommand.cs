namespace _01._Command_Pattern.Core.Models
{
    using _01._Command_Pattern.Core.Contracts;

    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
