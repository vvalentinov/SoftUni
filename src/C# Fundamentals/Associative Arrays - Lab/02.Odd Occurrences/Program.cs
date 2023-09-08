namespace _02.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                string item = word.ToLower();
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words.Add(item, 1);
                }
            }

            foreach (var item in words)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
