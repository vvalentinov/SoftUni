namespace _02.From_Left_to_The_Right
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int spaceIndex = line.IndexOf(' ');
                long firstNumber = long.Parse(line.Substring(0, spaceIndex));
                long secondNumber = long.Parse(line.Substring(spaceIndex + 1));
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(SumDigits(Math.Abs(firstNumber)));
                }
                else
                {
                    Console.WriteLine(SumDigits(Math.Abs(secondNumber)));
                }
            }
        }

        private static int SumDigits(long number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += (int)(number % 10);
                number /= 10;
            }
            return sum;
        }
    }
}
