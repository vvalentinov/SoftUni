namespace _04.Tourist_Shop
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int numberOfProducts = 0;
            double sum = 0;

            bool budgetIsEnough = true;
            string productName = Console.ReadLine();
            while (productName != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                numberOfProducts++;
                if (numberOfProducts % 3 == 0)
                {
                    productPrice /= 2;
                }
                if (productPrice > budget)
                {
                    budgetIsEnough = false;
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {productPrice - budget:f2} leva!");
                    break;
                }
                sum += productPrice;
                budget -= productPrice;
                productName = Console.ReadLine();
            }
            if (budgetIsEnough)
            {
                Console.WriteLine($"You bought {numberOfProducts} products for {sum:f2} leva.");
            }
        }
    }
}
