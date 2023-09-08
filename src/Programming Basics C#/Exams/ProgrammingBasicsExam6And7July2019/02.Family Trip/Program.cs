namespace _02.Family_Trip
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfNigths = int.Parse(Console.ReadLine());
            double priceForOneNigth = double.Parse(Console.ReadLine());
            int percentOtherExpences = int.Parse(Console.ReadLine());

            if (numberOfNigths > 7)
            {
                priceForOneNigth -= priceForOneNigth * 0.05;
                double priceForStay = numberOfNigths * priceForOneNigth;
                double percent = percentOtherExpences * 1.0 / 100 * budget;
                double total = priceForStay + percent;
                if (total <= budget)
                {
                    double diff = budget - total;
                    Console.WriteLine($"Ivanovi will be left with {diff:f2} leva after vacation.");
                }
                else
                {
                    double diff = total - budget;
                    Console.WriteLine($"{diff:f2} leva needed.");
                }
            }
            else
            {
                double priceForStay = numberOfNigths * priceForOneNigth;
                double percent = percentOtherExpences * 1.0 / 100 * budget;
                double total = priceForStay + percent;
                if (total <= budget)
                {
                    double diff = budget - total;
                    Console.WriteLine($"Ivanovi will be left with {diff:f2} leva after vacation.");
                }
                else
                {
                    double diff = total - budget;
                    Console.WriteLine($"{diff:f2} leva needed.");
                }
            }
        }
    }
}
