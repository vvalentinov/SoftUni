namespace _01._Action_Print
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine(x);
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.ForEach(input, print);
        }
    }
}
