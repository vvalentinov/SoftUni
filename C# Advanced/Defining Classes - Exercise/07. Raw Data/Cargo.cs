﻿namespace _07._Raw_Data
{
    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
