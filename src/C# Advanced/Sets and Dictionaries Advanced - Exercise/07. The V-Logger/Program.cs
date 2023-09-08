namespace _07._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        class Vlogger
        {
            public string Name { get; set; }
            public SortedSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }
            public Vlogger(string name)
            {
                this.Name = name;
                this.Followers = new SortedSet<string>();
                this.Following = new HashSet<string>();
            }
        }

        static void Main(string[] args)
        {
            HashSet<Vlogger> vloggers = new HashSet<Vlogger>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts[1] == "joined")
                {
                    Vlogger vlogger = new Vlogger(parts[0]);
                    bool containsVlogger = CheckIfContains(vloggers, vlogger);
                    if (!containsVlogger)
                    {
                        vloggers.Add(vlogger);
                    }
                }
                else
                {
                    string following = parts[0];
                    string followed = parts[2];
                    if (following == followed)
                    {
                        continue;
                    }
                    Vlogger firstVlogger = vloggers.Where(v => v.Name == following).FirstOrDefault();
                    Vlogger secondVlogger = vloggers.Where(v => v.Name == followed).FirstOrDefault();
                    if (vloggers.Contains(firstVlogger) &&
                        vloggers.Contains(secondVlogger) &&
                        !secondVlogger.Followers.Contains(following))
                    {
                        firstVlogger.Following.Add(followed);
                        secondVlogger.Followers.Add(following);
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int maxFollowers = int.MinValue;
            int maxFollowing = int.MinValue;
            Vlogger mostFamous = new Vlogger("");
            foreach (Vlogger vlogger in vloggers)
            {
                int currFollowers = vlogger.Followers.Count;
                if (currFollowers > maxFollowers)
                {
                    maxFollowers = currFollowers;
                    maxFollowing = vlogger.Following.Count;
                    mostFamous = vlogger;
                }
                else if (currFollowers == maxFollowers)
                {
                    int currFollowing = vlogger.Following.Count;
                    if (currFollowing < maxFollowing)
                    {
                        maxFollowers = vlogger.Followers.Count;
                        maxFollowing = vlogger.Following.Count;
                        mostFamous = vlogger;
                    }
                }
            }
            Console.WriteLine($"1. {mostFamous.Name} : {mostFamous.Followers.Count} followers, {mostFamous.Following.Count} following");
            if (mostFamous.Followers.Count > 0)
            {
                foreach (var follower in mostFamous.Followers)
                {
                    Console.WriteLine($"*  {follower}");
                }
            }
            int count = 2;
            vloggers.Remove(mostFamous);
            var ordered = vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Following.Count);
            foreach (Vlogger vlogger in ordered)
            {
                Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
                count++;
            }
        }

        private static bool CheckIfContains(HashSet<Vlogger> vloggers, Vlogger vlogger)
        {
            foreach (Vlogger item in vloggers)
            {
                if (item.Name == vlogger.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
