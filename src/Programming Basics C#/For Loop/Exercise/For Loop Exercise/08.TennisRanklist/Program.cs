namespace _08.TennisRanklist
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int wonTournamentsCount = 0;
            int avgPoints = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string tournamentOutcome = Console.ReadLine();
                switch (tournamentOutcome)
                {
                    case "W":
                        avgPoints += 2000;
                        points += 2000;
                        wonTournamentsCount++;
                        break;
                    case "F":
                        avgPoints += 1200;
                        points += 1200;
                        break;
                    case "SF":
                        avgPoints += 720;
                        points += 720;
                        break;
                }
            }

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(avgPoints * 1.0 / tournaments)}");
            Console.WriteLine($"{wonTournamentsCount * 1.0 / tournaments * 100:f2}%");
        }
    }
}
