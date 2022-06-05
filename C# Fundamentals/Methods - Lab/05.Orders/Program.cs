namespace _05.Orders
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalPrice(product, quantity);
        }
        private static void TotalPrice(string product, int quantity)
        {
            double total;
            if (product == "water")
            {
                total = quantity;
            }
            else if (product == "coffee")
            {
                total = 1.5 * quantity;
            }
            else if (product == "coke")
            {
                total = 1.4 * quantity;
            }
            else
            {
                total = 2 * quantity;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
