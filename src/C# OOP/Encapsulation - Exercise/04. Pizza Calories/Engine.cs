namespace _04._Pizza_Calories
{
    using _04._Pizza_Calories.Models;
    using System;

    public class Engine
    {
        public void Run()
        {
            try
            {
                Pizza pizza = MakePizza();
                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input.Split();

                    string command = tokens[0];
                    string toppingType = tokens[1];
                    double weight = double.Parse(tokens[2]);

                    Topping topping = new Topping(toppingType, weight);

                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        private static Pizza MakePizza()
        {
            string[] pizzaArgs = Console.ReadLine()
                .Split();
            string pizzaName = pizzaArgs[1];

            string[] dought = Console.ReadLine().Split();

            string flourType = dought[1];
            string backingTechnique = dought[2];
            double weight = double.Parse(dought[3]);

            Dough dough = new Dough(flourType, backingTechnique, weight);

            Pizza pizza = new Pizza(pizzaName, dough);
            return pizza;
        }
    }
}
