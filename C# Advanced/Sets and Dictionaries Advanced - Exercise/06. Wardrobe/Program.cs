namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = arr[0];
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                string[] items = arr[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in items)
                {
                    if (!clothes[color].ContainsKey(item))
                    {
                        clothes[color].Add(item, 0);
                    }
                    clothes[color][item]++;
                }
            }
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string targetColor = parts[0];
            string targetClothing = parts[1];
            foreach (var kvp in clothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var item in kvp.Value)
                {
                    if (kvp.Key == targetColor && item.Key == targetClothing)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }
        }
    }
}
