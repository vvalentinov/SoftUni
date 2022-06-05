namespace _08.Factorial_Division
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double factorialFirstNum = GetFactorialFirstNum(firstNumber);
            double factorialSecondNum = GetFactorialSecondNum(secondNumber);
            double division = factorialFirstNum / factorialSecondNum;
            Console.WriteLine($"{division:f2}");
        }
        private static double GetFactorialSecondNum(int secondNumber)
        {
            double result = 1;
            while (secondNumber != 1)
            {
                result *= secondNumber;
                secondNumber -= 1;
            }
            return result;
        }

        private static double GetFactorialFirstNum(int firstNumber)
        {
            double result = 1;
            while (firstNumber != 1)
            {
                result *= firstNumber;
                firstNumber -= 1;
            }
            return result;
        }
    }
}
