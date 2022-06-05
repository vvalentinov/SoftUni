namespace _01.Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> usersData = new Dictionary<string, Dictionary<string, int>>();
            string line = Console.ReadLine();
            while (line != "end of contests")
            {
                string[] arr = line.Split(":");
                string contest = arr[0];
                string password = arr[1];
                contests.Add(contest, password);
                line = Console.ReadLine();
            }
            string secondLine = Console.ReadLine();
            while (secondLine != "end of submissions")
            {
                string[] arr = secondLine.Split("=>");
                string contest = arr[0];
                string password = arr[1];
                string user = arr[2];
                int points = int.Parse(arr[3]);
                if (!contests.ContainsKey(contest))
                {
                    secondLine = Console.ReadLine();
                    continue;
                }
                if (contests[contest] != password)
                {
                    secondLine = Console.ReadLine();
                    continue;
                }
                if (usersData.ContainsKey(user) && usersData[user].ContainsKey(contest))
                {
                    if (points > usersData[user][contest])
                    {
                        usersData[user][contest] = points;
                    }
                }
                else if (usersData.ContainsKey(user))
                {
                    usersData[user].Add(contest, points);
                }
                else
                {
                    usersData.Add(user, new Dictionary<string, int>() { { contest, points } });
                }
                secondLine = Console.ReadLine();
            }
            Console.WriteLine(BestUser(usersData));
            Console.WriteLine("Ranking:");
            foreach (var kvp in usersData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
        private static string BestUser(Dictionary<string, Dictionary<string, int>> usersData)
        {
            string bestUser = string.Empty;
            int maxPoints = 0;
            int currPoints = 0;
            foreach (var kvp in usersData)
            {
                foreach (var item in kvp.Value)
                {
                    currPoints += item.Value;
                }
                if (currPoints > maxPoints)
                {
                    maxPoints = currPoints;
                    bestUser = kvp.Key;
                }
                currPoints = 0;
            }

            return $"Best candidate is {bestUser} with total {maxPoints} points.";
        }
    }
}
