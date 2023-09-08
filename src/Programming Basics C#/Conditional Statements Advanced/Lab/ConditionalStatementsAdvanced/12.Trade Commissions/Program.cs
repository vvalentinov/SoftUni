namespace _12.Trade_Commissions
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double capacityOfSales = double.Parse(Console.ReadLine());

            double comission = 0;
            switch (town)
            {
                case "Sofia":
                    if (capacityOfSales >= 0 && capacityOfSales <= 500)
                    {
                        comission = capacityOfSales * 0.05;
                    }
                    else if (capacityOfSales > 500 && capacityOfSales <= 1000)
                    {
                        comission = capacityOfSales * 0.07;
                    }
                    else if (capacityOfSales > 1000 && capacityOfSales <= 10000)
                    {
                        comission = capacityOfSales * 0.08;
                    }
                    else if (capacityOfSales > 10000)
                    {
                        comission = capacityOfSales * 0.12;
                    }
                    else if (capacityOfSales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (capacityOfSales >= 0 && capacityOfSales <= 500)
                    {
                        comission = capacityOfSales * 0.045;
                        
                    }
                    else if (capacityOfSales > 500 && capacityOfSales <= 1000)
                    {
                        comission = capacityOfSales * 0.075;
                    }
                    else if (capacityOfSales > 1000 && capacityOfSales <= 10000)
                    {
                        comission = capacityOfSales * 0.10;
                    }
                    else if (capacityOfSales > 10000)
                    {
                        comission = capacityOfSales * 0.13;
                    }
                    else if (capacityOfSales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (capacityOfSales >= 0 && capacityOfSales <= 500)
                    {
                        comission = capacityOfSales * 0.055;
                    }
                    else if (capacityOfSales > 500 && capacityOfSales <= 1000)
                    {
                        comission = capacityOfSales * 0.08;
                    }
                    else if (capacityOfSales > 1000 && capacityOfSales <= 10000)
                    {
                        comission = capacityOfSales * 0.12;
                    }
                    else if (capacityOfSales > 10000)
                    {
                        comission = capacityOfSales * 0.145;
                    }
                    else if (capacityOfSales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (comission != 0)
            {
                Console.WriteLine($"{comission:f2}");
            }
        }
    }
}
