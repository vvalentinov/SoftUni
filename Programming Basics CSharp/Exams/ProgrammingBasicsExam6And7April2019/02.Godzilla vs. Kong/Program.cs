namespace _02.Godzilla_vs._Kong
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStatists = int.Parse(Console.ReadLine());
            double priceForClothesForOneStatist = double.Parse(Console.ReadLine());

            double priceForDecor = budget * 0.1;
            double priceForClothes = numberOfStatists * priceForClothesForOneStatist;
            double total;
            if (numberOfStatists > 150)
            {
                priceForClothes -= priceForClothes * 0.1;
                total = priceForDecor + priceForClothes;
            }
            else
            {
                total = priceForDecor + priceForClothes;
            }

            if (total > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - total:f2} leva left.");
            }
        }
    }
}
