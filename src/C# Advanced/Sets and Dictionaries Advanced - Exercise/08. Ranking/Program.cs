namespace _08._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, List<string>> userByContests = new Dictionary<string, List<string>>();
            Dictionary<string, Dictionary<string, int>> userByContestByPoints = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of contests")
                {
                    break;
                }
                string[] parts = line.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = parts[0];
                string password = parts[1];
                contests.Add(contest, password);
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of submissions")
                {
                    break;
                }
                string[] parts = line.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = parts[0];
                string password = parts[1];
                string userName = parts[2];
                int points = int.Parse(parts[3]);
                if (!contests.ContainsKey(contest))
                {
                    continue;
                }
                if (contests[contest] != password)
                {
                    continue;
                }

                if (userByContests.ContainsKey(userName))
                {
                    if (userByContestByPoints[userName].ContainsKey(contest)
                        && userByContestByPoints[userName][contest] < points)
                    {
                        userByContestByPoints[userName][contest] = points;
                    }
                    else if (!userByContestByPoints[userName].ContainsKey(contest))
                    {
                        userByContestByPoints[userName].Add(contest, points);
                    }
                }
                else
                {
                    userByContestByPoints.Add(userName, new Dictionary<string, int>());
                    userByContestByPoints[userName].Add(contest, points);
                    userByContests.Add(userName, new List<string>() { contest });
                }
            }
            PrintBestCandidate(userByContestByPoints);
            Console.WriteLine("Ranking:");
            var ordered = userByContestByPoints.OrderBy(x => x.Key);
            foreach (var kvp in ordered)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in userByContestByPoints[kvp.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }

        private static void PrintBestCandidate(Dictionary<string, Dictionary<string, int>> userByContestByPoints)
        {
            int max = int.MinValue;
            int currMax = 0;
            string bestCandidate = string.Empty;
            foreach (var kvp in userByContestByPoints)
            {
                string candidate = kvp.Key;
                foreach (var item in userByContestByPoints[kvp.Key])
                {
                    currMax += item.Value;
                }
                if (currMax > max)
                {
                    max = currMax;
                    bestCandidate = candidate;
                }
                currMax = 0;
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {max} points.");
        }
    }
}
