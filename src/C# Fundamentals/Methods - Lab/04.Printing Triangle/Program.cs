namespace _04.Printing_Triangle
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }
        private static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < number; i++)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
