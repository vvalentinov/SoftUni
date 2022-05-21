namespace _05.Small_Shop
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    double finalSum = quantity * 0.50;
                    Console.WriteLine(finalSum);
                }
                else if (product == "water")
                {
                    double finalSum = quantity * 0.80;
                    Console.WriteLine(finalSum);
                }
                else if (product == "beer")
                {
                    double finalSum = quantity * 1.20;
                    Console.WriteLine(finalSum);
                }
                else if (product == "sweets")
                {
                    double finalSum = quantity * 1.45;
                    Console.WriteLine(finalSum);
                }
                else if (product == "peanuts")
                {
                    double finalSum = quantity * 1.60;
                    Console.WriteLine(finalSum);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    double finalSum = quantity * 0.40;
                    Console.WriteLine(finalSum);
                }
                else if (product == "water")
                {
                    double finalSum = quantity * 0.70;
                    Console.WriteLine(finalSum);
                }
                else if (product == "beer")
                {
                    double finalSum = quantity * 1.15;
                    Console.WriteLine(finalSum);
                }
                else if (product == "sweets")
                {
                    double finalSum = quantity * 1.30;
                    Console.WriteLine(finalSum);
                }
                else if (product == "peanuts")
                {
                    double finalSum = quantity * 1.50;
                    Console.WriteLine(finalSum);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    double finalSum = quantity * 0.45;
                    Console.WriteLine(finalSum);
                }
                else if (product == "water")
                {
                    double finalSum = quantity * 0.70;
                    Console.WriteLine(finalSum);
                }
                else if (product == "beer")
                {
                    double finalSum = quantity * 1.10;
                    Console.WriteLine(finalSum);
                }
                else if (product == "sweets")
                {
                    double finalSum = quantity * 1.35;
                    Console.WriteLine(finalSum);
                }
                else if (product == "peanuts")
                {
                    double finalSum = quantity * 1.55;
                    Console.WriteLine(finalSum);
                }
            }
        }
    }
}
