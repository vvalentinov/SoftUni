namespace _03.Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    words[word].Add(synonim);
                }
                else
                {
                    words.Add(word, new List<string>() { synonim });
                }
            }

            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
