namespace _06.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(^|(?<=\s))[a-zA-Z\d]+([-._][a-zA-Z\d]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z]+)+");

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
