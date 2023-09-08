namespace _11.Orders
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < countOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double price = days * capsulesCount * pricePerCapsule;
                total += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
