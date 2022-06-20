namespace Easter.Models.Eggs
{
    using Easter.Models.Eggs.Contracts;
    using Easter.Utilities.Messages;
    using System;

    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;
        public Egg(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEggName);
                }
                this.name = value;
            }
        }

        public int EnergyRequired
        {
            get
            {
                return this.energyRequired;
            }
            private set
            {
                if (value < 0)
                {
                    this.energyRequired = 0;
                }
                else
                {
                    this.energyRequired = value;
                }
            }
        }

        public void GetColored()
        {
            this.energyRequired -= 10;
            if (this.energyRequired < 0)
            {
                this.energyRequired = 0;
            }
        }

        public bool IsDone()
        {
            return this.energyRequired == 0;
        }
    }
}
