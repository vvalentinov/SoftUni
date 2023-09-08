namespace _05._Football_Team_Generator.Models
{
    using _05._Football_Team_Generator.Common;
    using System;

    public class Stats
    {
        private const int MIN_STAT = 0;
        private const int MAX_STAT = 100;
        private const double STATS_COUNT = 5;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return endurance;
            }
            private set
            {
                ValidateStat(nameof(Endurance), value);
                endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return sprint;
            }
            private set
            {
                ValidateStat(nameof(Endurance), value);
                sprint = value;
            }
        }
        public int Dribble
        {
            get
            {
                return dribble;
            }
            private set
            {
                ValidateStat(nameof(Dribble), value);
                dribble = value;
            }
        }
        public int Passing
        {
            get
            {
                return passing;
            }
            private set
            {
                ValidateStat(nameof(Passing), value);
                passing = value;
            }
        }
        public int Shooting
        {
            get
            {
                return shooting;
            }
            private set
            {
                ValidateStat(nameof(Shooting), value);
                shooting = value;
            }
        }

        public double AverageStat => (Endurance + Sprint + Dribble + Passing + Shooting) / STATS_COUNT;
        private void ValidateStat(string name, int value)
        {
            if (value < MIN_STAT || value > MAX_STAT)
            {
                throw new ArgumentException(string.Format(GlobalConstants.InvalidStatExcMsg, name, MIN_STAT, MAX_STAT));
            }
        }

    }
}
