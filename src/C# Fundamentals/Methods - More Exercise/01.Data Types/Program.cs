namespace _01.Data_Types
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Output(Console.ReadLine());
        }
        static void Output(string input)
        {
            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
            else if (input == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number * 1.5:f2}");
            }
            else
            {
                string word = Console.ReadLine();
                Console.WriteLine($"${word}$");
            }
        }
    }
}
