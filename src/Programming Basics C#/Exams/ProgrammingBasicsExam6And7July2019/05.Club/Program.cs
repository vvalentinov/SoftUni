namespace _05.Club
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double wishedProfit = double.Parse(Console.ReadLine());
            double totalProfit = 0;
            while (true)
            {
                string cocteil = Console.ReadLine();
                if (cocteil == "Party!")
                {
                    Console.WriteLine($"We need {wishedProfit - totalProfit:f2} leva more.");
                    Console.WriteLine($"Club income - {totalProfit:f2} leva.");
                    break;
                }
                int numberOfCocteils = int.Parse(Console.ReadLine());
                double currProfit = numberOfCocteils * cocteil.Length;
                if (currProfit % 2 != 0)
                {
                    currProfit -= currProfit * 0.25;
                }
                totalProfit += currProfit;
                if (totalProfit >= wishedProfit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {totalProfit:f2} leva.");
                    break;
                }
            }
        }
    }
}
