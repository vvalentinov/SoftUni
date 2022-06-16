namespace _04._Pizza_Calories.Models
{
    using System;

    public class Topping
    {
        private const string INVALID_EXP_TYPE_MSG = "Cannot place {0} on top of your pizza.";
        private const string INVALID_EXP_WEIGHT_MSG = "{0} weight should be in the range [1..50].";
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "sauce" && value.ToLower() != "cheese")
                {
                    throw
                        new ArgumentException
                        (string.Format(INVALID_EXP_TYPE_MSG, value));
                }
                type = value;
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw
                        new ArgumentException
                        (string.Format(INVALID_EXP_WEIGHT_MSG, Type));
                }
                weight = value;
            }
        }
        private double GetTypeModifier()
        {
            if (Type.ToLower() == "meat")
            {
                return 1.2;
            }
            else if (Type.ToLower() == "veggies")
            {
                return 0.8;
            }
            else if (Type.ToLower() == "cheese")
            {
                return 1.1;
            }
            else
            {
                return 0.9;
            }
        }
        public double GetCalories()
        {
            return 2 * Weight * GetTypeModifier();
        }
    }
}
