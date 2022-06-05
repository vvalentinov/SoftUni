namespace _02.Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestsUsers = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> usersContests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> users = new Dictionary<string, int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "no more time")
                {
                    break;
                }
                string[] arr = line.Split(" -> ");
                string user = arr[0];
                string contest = arr[1];
                int points = int.Parse(arr[2]);
                if (usersContests.ContainsKey(user) && usersContests[user].ContainsKey(contest))
                {
                    if (usersContests[user][contest] < points)
                    {
                        usersContests[user][contest] = points;
                    }
                }
                else if (usersContests.ContainsKey(user))
                {
                    usersContests[user].Add(contest, points);
                }
                else
                {
                    usersContests.Add(user, new Dictionary<string, int>() { { contest, points } });
                }

                if (contestsUsers.ContainsKey(contest) && contestsUsers[contest].ContainsKey(user))
                {
                    if (contestsUsers[contest][user] < points)
                    {
                        contestsUsers[contest][user] = points;
                    }
                }
                else if (contestsUsers.ContainsKey(contest))
                {
                    contestsUsers[contest].Add(user, points);
                }
                else
                {
                    contestsUsers.Add(contest, new Dictionary<string, int>() { { user, points } });
                }
            }
            int count = 0;
            foreach (var kvp in contestsUsers)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {item.Key} <::> {item.Value}");
                }
                count = 0;
            }
            Console.WriteLine("Individual standings:");
            foreach (var kvp in usersContests)
            {
                int sum = 0;
                foreach (var item in kvp.Value)
                {
                    sum += item.Value;
                }
                users.Add(kvp.Key, sum);
            }
            foreach (var item in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                count++;
                Console.WriteLine($"{count}. {item.Key} -> {item.Value}");
            }
        }
    }
}
