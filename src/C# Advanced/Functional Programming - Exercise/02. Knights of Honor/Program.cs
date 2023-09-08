namespace _02._Knights_of_Honor
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => $"Sir {x}")
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
