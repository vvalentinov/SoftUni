namespace _03.MOBA_Challenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Season end")
                {
                    break;
                }
                if (line.Contains("->"))
                {
                    string[] arr = line.Split(" -> ");
                    string player = arr[0];
                    string position = arr[1];
                    int skill = int.Parse(arr[2]);

                    if (players.ContainsKey(player) && players[player].ContainsKey(position))
                    {
                        if (players[player][position] < skill)
                        {
                            players[player][position] = skill;
                        }
                    }
                    else if (players.ContainsKey(player))
                    {
                        players[player].Add(position, skill);
                    }
                    else
                    {
                        players.Add(player, new Dictionary<string, int>() { { position, skill } });
                    }
                }
                else
                {
                    string[] arr = line.Split(" vs ");
                    string playerOne = arr[0];
                    string playerTwo = arr[1];

                    if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        if (HaveCommonPosition(players, playerOne, playerTwo))
                        {
                            int totalPointsFirst = players[playerOne].Values.Sum();
                            int totalPointsSecond = players[playerTwo].Values.Sum();

                            if (totalPointsFirst > totalPointsSecond)
                            {
                                players.Remove(playerTwo);
                            }
                            else if (totalPointsFirst < totalPointsSecond)
                            {
                                players.Remove(playerOne);
                            }
                        }
                    }
                }
            }


            foreach (var kvp in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
        private static bool HaveCommonPosition(Dictionary<string, Dictionary<string, int>> players, string playerOne, string playerTwo)
        {
            foreach (var item in players[playerOne])
            {
                foreach (var kvp in players[playerTwo])
                {
                    if (item.Key == kvp.Key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
