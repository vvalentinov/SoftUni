namespace _04.FishingBoat
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double priceShip = 0;
            switch (season)
            {
                case "Spring":
                    priceShip = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    priceShip = 4200;
                    break;
                case "Winter":
                    priceShip = 2600;
                    break;
            }

            
            if (fishers <= 6)
            {
                priceShip *= 0.9;
            }
            else if (fishers >= 7 && fishers <= 11)
            {
                priceShip *= 0.85;
            }
            else
            {
                priceShip *= 0.75;
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                priceShip *= 0.95;
            }

            if (priceShip > budget)
            {
                Console.WriteLine($"Not enough money! You need {priceShip - budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget - priceShip:f2} leva left.");
            }
        }
    }
}
