namespace _02.Safari
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litresNeeded = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double priceForFuel = litresNeeded * 2.1;
            double price = priceForFuel + 100;
            if (day == "Saturday")
            {
                price -= price * 0.1;
            }
            else if (day == "Sunday")
            {
                price -= price * 0.2;
            }

            if (price <= budget)
            {
                Console.WriteLine($"Safari time! Money left: {budget - price:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {price - budget:f2} lv.");
            }
        }
    }
}
