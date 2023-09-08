namespace _04.Text_Filter
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder(text);

            foreach (var word in bannedWords)
            {
                string newString = new string('*', word.Length);
                sb.Replace(word, newString);
            }

            Console.WriteLine(sb);
        }
    }
}
