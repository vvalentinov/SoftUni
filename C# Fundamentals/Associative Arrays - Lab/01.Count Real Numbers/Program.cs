namespace _01.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> result = new Dictionary<double, int>();

            foreach (var item in numbers)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
            }

            foreach (var item in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
