namespace _07.Vending_Machine
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double sumCoins = 0;
            string input = Console.ReadLine();
            do
            {
                double coin = double.Parse(input);
                switch (coin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        sumCoins += coin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                input = Console.ReadLine();
            } while (input != "Start");

            string product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sumCoins >= 2)
                        {
                            Console.WriteLine("Purchased nuts");
                            sumCoins -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sumCoins >= 0.7)
                        {
                            Console.WriteLine("Purchased water");
                            sumCoins -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sumCoins >= 1.5)
                        {
                            Console.WriteLine("Purchased crisps");
                            sumCoins -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sumCoins >= 0.8)
                        {
                            Console.WriteLine("Purchased soda");
                            sumCoins -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sumCoins >= 1)
                        {
                            Console.WriteLine("Purchased coke");
                            sumCoins--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoins:f2}");
        }
    }
}
