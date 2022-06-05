namespace _02.Match_Phone_Number
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();

            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            Regex regex = new Regex(pattern);
            string phones = Console.ReadLine();

            MatchCollection matches = regex.Matches(phones);

            foreach (var item in matches)
            {
                string number = item.ToString();
                numbers.Add(number);
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
