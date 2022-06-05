namespace _01.Sign_of_Integer_Numbers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Sign(number));
        }
        private static string Sign(int number)
        {
            if (number > 0)
            {
                return $"The number {number} is positive.";
            }
            else if (number == 0)
            {
                return $"The number {number} is zero.";
            }
            else
            {
                return $"The number {number} is negative.";
            }
        }
    }
}
