namespace _04.Orders
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();
            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] currentPRoducts = command.Split();
                string productName = currentPRoducts[0];
                double productPrice = double.Parse(currentPRoducts[1]);
                double quantity = double.Parse(currentPRoducts[2]);
                if (!output.ContainsKey(productName))
                {
                    List<double> priceAndQuantity = new List<double>() { productPrice, quantity };
                    output.Add(productName, priceAndQuantity);
                }
                else
                {
                    output[productName][0] = productPrice;
                    output[productName][1] = output[productName][1] + quantity;
                }


                command = Console.ReadLine();
            }
            foreach (var item in output)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
