namespace _05.Journey
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string place = string.Empty;
            double sum = budget;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                (place, sum) = season == "summer" ? ("Camp", sum * 0.3) : ("Hotel", sum * 0.7);
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                (place, sum) = season == "summer" ? ("Camp", sum * 0.4) : ("Hotel", sum * 0.8);
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                sum *= 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {sum:f2}");
        }
    }
}
