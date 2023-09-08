namespace _04._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }
                string[] parts = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = parts[0];
                string product = parts[1];
                double price = double.Parse(parts[2]);
                if (shops.ContainsKey(shop))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops.Add(shop, new Dictionary<string, double>() { { product, price } });
                }
            }
            var ordered = shops.OrderBy(x => x.Key);
            foreach (var kvp in ordered)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var product in kvp.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
