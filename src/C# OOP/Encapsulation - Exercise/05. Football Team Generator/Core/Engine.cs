namespace _05._Football_Team_Generator.Core
{
    using _05._Football_Team_Generator.Common;
    using _05._Football_Team_Generator.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private readonly ICollection<Team> teams;
        public Engine()
        {
            teams = new List<Team>();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArg = command.Split(';');
                string cmdType = cmdArg[0];
                try
                {
                    List<string> cmdParams = cmdArg.Skip(1).ToList();
                    if (cmdType == "Team")
                    {
                        CreateTeam(cmdParams);
                    }
                    else if (cmdType == "Add")
                    {
                        AddPlayerToTeam(cmdParams);
                    }
                    else if (cmdType == "Remove")
                    {
                        RemovePlayerFromTeam(cmdParams);
                    }
                    else if (cmdType == "Rating")
                    {
                        RateTeam(cmdParams);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
        }

        private void CreateTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            Team team = new Team(teamName);
            teams.Add(team);
        }
        private void AddPlayerToTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            string playerName = cmdArgs[1];
            ValidateTeamExists(teamName);
            Stats stats = BuildStats(cmdArgs.Skip(2).ToArray());
            Player player = new Player(playerName, stats);
            Team team = teams.First(t => t.Name == teamName);
            team.AddPlayer(player);
        }
        private void RemovePlayerFromTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            string playerName = cmdArgs[1];
            ValidateTeamExists(teamName);
            Team team = teams.First(t => t.Name == teamName);
            team.RemovePlayer(playerName);
        }

        private Stats BuildStats(string[] statsString)
        {
            int endurance = int.Parse(statsString[0]);
            int sprint = int.Parse(statsString[1]);
            int dribble = int.Parse(statsString[2]);
            int passing = int.Parse(statsString[3]);
            int shooting = int.Parse(statsString[4]);
            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);
            return stats;
        }
        private void RateTeam(IList<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            ValidateTeamExists(teamName);
            Team team = teams.First(t => t.Name == teamName);
            Console.WriteLine(team);
        }
        private void ValidateTeamExists(string teamName)
        {
            if (!teams.Any(t => t.Name == teamName))
            {
                throw new InvalidOperationException(string.Format(GlobalConstants.MissingTeamExcMsg, teamName));
            }
        }
    }
}
