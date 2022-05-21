namespace _05.Godzilla_vs._Kong
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStatists = int.Parse(Console.ReadLine());
            double priceForClothesForOneStatist = double.Parse(Console.ReadLine());

            double decor = 0.10 * budget;
            double priceForClothes = priceForClothesForOneStatist * numberOfStatists;
            double priceForMovie = priceForClothes + decor;
            double priceForClothesAfterDiscount = priceForClothes - (priceForClothes * 0.10);
            double priceForMovieAfterDiscount = priceForClothesAfterDiscount + decor;
            if (numberOfStatists >= 150 && priceForMovieAfterDiscount < budget)
            {
                double moneyLeft = budget - priceForMovieAfterDiscount;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else if (numberOfStatists >= 150 && priceForMovieAfterDiscount > budget)
            {
                double moneyNeeded = priceForMovieAfterDiscount - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else if (numberOfStatists >= 150 && priceForMovieAfterDiscount == budget)
            {
                double moneyNeeded = 0;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyNeeded:f2} leva left.");
            }
            else if (numberOfStatists < 150 && priceForMovie < budget)
            {
                double moneyLeft = budget - priceForMovie;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else if (numberOfStatists < 150 && priceForMovie == budget)
            {
                double moneyLeft = 0;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else if (numberOfStatists < 150 && priceForMovie > budget)
            {
                double moneyNeeded = priceForMovie - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
        }
    }
}
