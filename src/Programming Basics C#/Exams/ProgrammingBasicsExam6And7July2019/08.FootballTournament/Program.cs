namespace _08.FootballTournament
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfGames = int.Parse(Console.ReadLine());
            if (numberOfGames == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
            }
            else
            {
                int countD = 0;
                int countW = 0;
                int countL = 0;
                for (int i = 1; i <= numberOfGames; i++)
                {
                    char outcome = Convert.ToChar(Console.ReadLine());
                    if (outcome == 'W')
                    {
                        countW++;
                    }
                    else if (outcome == 'D')
                    {
                        countD++;
                    }
                    else if (outcome == 'L')
                    {
                        countL++;
                    }
                }
                int points = countW * 3 + countD * 1;
                double winRate = countW * 1.0 / numberOfGames * 100;
                Console.WriteLine($"{name} has won {points} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {countW}");
                Console.WriteLine($"## D: {countD}");
                Console.WriteLine($"## L: {countL}");
                Console.WriteLine($"Win rate: {winRate:f2}%");
            }
        }
    }
}
