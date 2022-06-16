namespace _05._Football_Team_Generator.Models
{
    using _05._Football_Team_Generator.Common;
    using System;

    public class Player
    {
        private string name;
        public Player(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
        }
        public string Name 
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExcMsg);
                }
                name = value;
            }
        }
        public Stats Stats { get; set; }
        public double OverallSkill => Stats.AverageStat;
    }
}
