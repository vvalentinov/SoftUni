namespace _03.Substring
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string rmWord = Console.ReadLine().ToLower();

            string input = Console.ReadLine().ToLower();

            string result = input.Replace(rmWord, string.Empty);

            while (result.Contains(rmWord))
            {
                result = result.Replace(rmWord, string.Empty);
            }

            Console.WriteLine(result);
        }
    }
}
