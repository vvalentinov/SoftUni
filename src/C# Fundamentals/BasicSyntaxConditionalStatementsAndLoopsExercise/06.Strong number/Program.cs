namespace _06.Strong_number
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int number = input;
            int currNumber = 0;
            int factorialSum = 0;
            while (number != 0)
            {
                currNumber = number % 10;
                number /= 10;
                int factorial = 1;
                for (int i = 1; i <= currNumber; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            if (input == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
