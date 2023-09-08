namespace _06.Middle_Characters
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output;
            if (input.Length % 2 == 0)
            {
                output = GetMiddleCharFromEvenStringLenght(input);
            }
            else
            {
                output = GetMiddleCharFromOddStringLenght(input);
            }
            Console.WriteLine(output);
        }
        private static string GetMiddleCharFromOddStringLenght(string input)
        {
            return input.Substring(input.Length / 2, 1);
        }

        private static string GetMiddleCharFromEvenStringLenght(string input)
        {
            return input.Substring((input.Length / 2) - 1, 2);
        }
    }
}
