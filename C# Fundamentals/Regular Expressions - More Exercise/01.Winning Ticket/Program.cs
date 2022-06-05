namespace _01.Winning_Ticket
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"@{6,10}|#{6,10}|\${6,10}|\^{6,10}");
            foreach (var item in tickets)
            {
                if (item.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftSide = item.Substring(0, 10);
                string rightSide = item.Substring(10, 10);
                Match matchLeft = regex.Match(leftSide);
                Match matchRight = regex.Match(rightSide);
                if (!matchLeft.Success || !matchRight.Success)
                {
                    Console.WriteLine($"ticket \"{item}\" - no match");
                    continue;
                }
                string left = matchLeft.ToString();
                string right = matchRight.ToString();
                if (left[0] != right[0])
                {
                    Console.WriteLine($"ticket \"{item}\" - no match");
                    continue;
                }
                if (matchLeft.Length == 10 && matchRight.Length == 10)
                {
                    string ticket = matchLeft.ToString();
                    char sym = ticket[0];
                    Console.WriteLine($"ticket \"{item}\" - 10{sym} Jackpot!");
                    continue;
                }
                string winning = matchLeft.Length > matchRight.Length ? matchRight.ToString() : matchLeft.ToString();
                char symbol = winning[0];
                Console.WriteLine($"ticket \"{item}\" - {winning.Length}{symbol}");
            }
        }
    }
}
