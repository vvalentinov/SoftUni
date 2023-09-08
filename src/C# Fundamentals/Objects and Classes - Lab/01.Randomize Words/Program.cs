namespace _01.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int index = rnd.Next(0, words.Count);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
