namespace _10.Multiply_Evens_by_Odds
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
        private static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
