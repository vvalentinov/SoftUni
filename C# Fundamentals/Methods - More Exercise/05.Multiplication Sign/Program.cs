namespace _05.Multiplication_Sign
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (IsNegative(num1, num2, num3))
            {
                Console.WriteLine("negative");
            }
            if (IsZero(num1, num2, num3))
            {
                Console.WriteLine("zero");
            }
            if (IsPositive(num1, num2, num3))
            {
                Console.WriteLine("positive");
            }
        }
        static bool IsPositive(int a, int b, int c)
        {
            if ((a < 0  && b < 0 && c > 0) ||
                (b < 0 && c < 0 && a > 0) ||
                (a < 0 && c < 0 && b > 0) ||
                (a > 0 && b > 0 && c > 0))
            {
                return true;
            }
            return false;
        }
        static bool IsZero(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return true;
            }
            return false;
        }
        static bool IsNegative(int a, int b, int c)
        {
            if ((a > 0 && b > 0 && c < 0) ||
                (b > 0 && c > 0 && a < 0) ||
                (a > 0 && c > 0 && b < 0) ||
                (a < 0 && b < 0 && c < 0))
            {
                return true;
            }
            return false;
        }
    }
}
