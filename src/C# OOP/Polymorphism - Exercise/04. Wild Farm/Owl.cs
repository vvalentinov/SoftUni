﻿namespace _04._Wild_Farm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
