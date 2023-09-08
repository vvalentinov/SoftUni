namespace _10._ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "Lumpawaroo")
            {
                if (command.Contains(" | "))
                {
                    string[] parts = command.Split(" | ");
                    bool userExists = false;
                    foreach (var team in teams)
                    {
                        if (team.Value.Contains(parts[1]))
                        {
                            userExists = true;
                        }
                    }

                    if (teams.ContainsKey(parts[0]))
                    {
                        if (userExists == false)
                        {
                            teams[parts[0]].Add(parts[1]);
                        }
                    }
                    else
                    {
                        teams.Add(parts[0], new List<string>());
                        if (userExists == false)
                        {
                            teams[parts[0]].Add(parts[1]);
                        }
                    }
                }
                else if (command.Contains(" -> "))
                {
                    string[] parts = command.Split(" -> ");
                    foreach (var team in teams)
                    {
                        if (team.Value.Contains(parts[0]))
                        {
                            team.Value.Remove(parts[0]);
                        }
                    }
                    if (teams.ContainsKey(parts[1]) == false)
                    {
                        teams.Add(parts[1], new List<string>());
                    }

                    teams[parts[1]].Add(parts[0]);
                    Console.WriteLine($"{parts[0]} joins the {parts[1]} side!");
                }
                command = Console.ReadLine();
            }


            var teamsOrderedAndFiltered = teams
                .Where(x => x.Value.Count >= 1)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);
            foreach (var kvp in teamsOrderedAndFiltered)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                foreach (var item in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }
    }
}
