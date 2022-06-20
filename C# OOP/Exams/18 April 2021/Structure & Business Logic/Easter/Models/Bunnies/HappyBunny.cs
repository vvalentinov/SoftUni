﻿namespace Easter.Models.Bunnies
{
    public class HappyBunny : Bunny
    {
        private const int initialEnergy = 100;
        public HappyBunny(string name) : base(name, initialEnergy)
        {
        }

        public override void Work()
        {
            this.Energy -= 10;
        }
    }
}
