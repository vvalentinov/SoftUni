namespace _03.Characters_in_Range
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Output(first, second);
        }
        static void Output(char a, char b)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else if (a > b)
            {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
