namespace _03.Floating_Equality
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isEqual = true;
            double result;
            if (a > b)
            {
                result = a - b;
                if (result > eps)
                {
                    isEqual = false;
                }
            }
            else if (a < b)
            {
                result = b - a;
                if (result > eps)
                {
                    isEqual = false;
                }
            }
            Console.WriteLine(isEqual);
        }
    }
}
