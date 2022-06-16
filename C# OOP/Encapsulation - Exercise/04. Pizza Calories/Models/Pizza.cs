namespace _04._Pizza_Calories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private const string INVALID_MSG_PIZZANAME_EXP = "Pizza name should be between 1 and 15 symbols.";
        private const string INVALID_MSG_PIZZARANGE_EXP = "Number of toppings should be in range [0..10].";
        private string name;

        private readonly ICollection<Topping> toppings;
        private Pizza()
        {
            toppings = new List<Topping>();
        }
        public Pizza(string name, Dough dough):this()
        {
            Name = name;
            Dough = dough;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length<1 || value.Length>15)
                {
                    throw new ArgumentException(INVALID_MSG_PIZZANAME_EXP);
                }
                name = value;
            }
        }
        public Dough Dough { get; private set; }

        public IReadOnlyCollection<Topping> Toppings => (IReadOnlyCollection<Topping>)toppings;
        public void AddTopping(Topping topping)
        {
            if (toppings.Count>10)
            {
                throw new
                    ArgumentException
                    (INVALID_MSG_PIZZARANGE_EXP);
            }
            toppings.Add(topping);
        }
        public double TotalCalories => Dough.CalculateTotalCalories() 
            + Toppings.Sum(x => x.GetCalories());
        public override string ToString()
        {
            return $"{Name} - {TotalCalories:F2} Calories.".TrimEnd();
        }

    }
}
