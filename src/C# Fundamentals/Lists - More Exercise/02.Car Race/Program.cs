namespace _02.Car_Race
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int midIdx = numbers.Length / 2;
            double timeLeft = 0;
            double timeRight = 0;

            for (int i = 0; i < midIdx; i++)
            {
                if (numbers[i] == 0)
                {
                    timeLeft *= 0.8;
                }
                else
                {
                    numbers[i] = Math.Abs(numbers[i]);
                    timeLeft += numbers[i];
                }
            }
            for (int i = numbers.Length - 1; i > midIdx; i--)
            {
                if (numbers[i] == 0)
                {
                    timeRight *= 0.8;
                }
                else
                {
                    numbers[i] = Math.Abs(numbers[i]);
                    timeRight += numbers[i];
                }
            }
            timeLeft = Math.Round(timeLeft, 1);
            timeRight = Math.Round(timeRight, 1);
            if (timeLeft < timeRight)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeRight}");
            }
        }
    }
}
