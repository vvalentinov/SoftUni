namespace _03._Count_Uppercase_Words
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            PrintResult(text, CheckString);
        }
        private static bool CheckString(string word)
        {
            return char.IsUpper(word[0]);
        }
        private static void PrintResult(string[] arr, Func<string, bool> check)
        {
            foreach (string word in arr)
            {
                if (check(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
