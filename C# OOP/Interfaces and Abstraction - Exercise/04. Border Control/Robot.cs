﻿namespace _04._Border_Control
{
    public class Robot : IRobot
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Model { get; set; }
        public string Id { get; set; }
    }
}
