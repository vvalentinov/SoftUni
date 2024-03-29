﻿namespace _08._Car_Salesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(
            string model,
            int power,
            string displacement,
            string efficiency) : this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
