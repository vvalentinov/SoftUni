namespace _06.World_Swimming_Record
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMetres = double.Parse(Console.ReadLine());
            double secondsForOneMetre = double.Parse(Console.ReadLine());

            double secondsForDistance = distanceMetres * secondsForOneMetre;
            double addedSecondsForDistance = Math.Floor(distanceMetres / 15) * 12.5;
            double totalSecondsForDistance = secondsForDistance + addedSecondsForDistance;

            if (totalSecondsForDistance >= recordSeconds)
            {
                double secondsSlower = totalSecondsForDistance - recordSeconds;
                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSecondsForDistance:f2} seconds.");
            }
        }
    }
}
