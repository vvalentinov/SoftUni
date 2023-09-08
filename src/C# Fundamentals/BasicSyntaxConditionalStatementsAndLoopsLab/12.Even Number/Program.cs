namespace _12.Even_Number
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
            }
            else
            {
                Console.WriteLine("Please write an even number.");
            }
        }
    }
}
