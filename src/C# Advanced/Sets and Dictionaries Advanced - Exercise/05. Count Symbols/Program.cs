namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> occurencies = new SortedDictionary<char, int>();
            foreach (char element in text)
            {
                if (!occurencies.ContainsKey(element))
                {
                    occurencies.Add(element, 0);
                }
                occurencies[element]++;
            }
            foreach (var kvp in occurencies)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
