namespace _08.Lunch_Break
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            double lunchLength = breakLength * 1.0 / 8;
            double chillLength = breakLength * 1.0 / 4;

            double remainingTime = breakLength - lunchLength - chillLength;
            if (remainingTime >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime - episodeLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLength - remainingTime)} more minutes.");
            }
        }
    }
}
