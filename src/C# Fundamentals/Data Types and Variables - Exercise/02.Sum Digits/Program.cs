namespace _02.Sum_Digits
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
                int digit = a % 10;
                sum += digit;
                a /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
