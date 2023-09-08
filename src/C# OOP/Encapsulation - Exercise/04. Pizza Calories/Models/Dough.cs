namespace _04._Pizza_Calories.Models
{
    using System;

    public class Dough
    {
        private string flourType;
        private string backingTechniques;
        private double weight;

        private const string INVALID_TYPE_OF_DOUGH = "Invalid type of dough.";
        private const string INVALID_WEIGHT_OF_DOUGH = "Dough weight should be in the range [1..200].";

        public Dough(string flourType, string backingTechniques, double weight)
        {
            FlourType = flourType;
            BackingTechniques = backingTechniques;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(INVALID_TYPE_OF_DOUGH);
                }
                flourType = value;
            }
        }
        public string BackingTechniques
        {
            get => backingTechniques;
            private set
            {
                if (value.ToLower() != "chewy" && value.ToLower() != "crispy"
                    && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(INVALID_TYPE_OF_DOUGH);
                }
                backingTechniques = value;
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(INVALID_WEIGHT_OF_DOUGH);
                }
                weight = value;
            }
        }
        private double GetFlourTypeModifier()
        {
            if (FlourType.ToLower() == "white")
            {
                return 1.5;
            }
            else
            {
                return 1.0;
            }
        }
        private double GetBackingTechniqueTypeModifier()
        {
            if (BackingTechniques.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (BackingTechniques.ToLower() == "chewy")
            {
                return 1.1;
            }
            else
            {
                return 1.0;
            }
        }
        public double CalculateTotalCalories()
        {
            return 2 * Weight * GetFlourTypeModifier() * GetBackingTechniqueTypeModifier();
        }
    }
}
