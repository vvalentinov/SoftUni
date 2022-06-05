namespace _01.Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();
            Dictionary<char, int> occurencies = new Dictionary<char, int>();
            foreach (var letter in letters)
            {
                if (letter != ' ')
                {
                    if (!occurencies.ContainsKey(letter))
                    {
                        occurencies.Add(letter, 0);
                    }
                    occurencies[letter]++;
                }
            }
            foreach (var item in occurencies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
