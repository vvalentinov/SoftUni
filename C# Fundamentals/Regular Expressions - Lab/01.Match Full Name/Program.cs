namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";
            Regex regex = new Regex(pattern);

            string names = Console.ReadLine();

            MatchCollection matches = regex.Matches(names);

            foreach (Match name in matches)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
