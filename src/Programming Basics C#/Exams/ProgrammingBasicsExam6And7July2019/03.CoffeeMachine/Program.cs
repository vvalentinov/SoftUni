namespace _03.CoffeeMachine
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());

            double priceForDrinks = 0;

            switch (drink)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        double priceForDrinksWithoutDiscount = numberOfDrinks * 0.9;
                        priceForDrinks = priceForDrinksWithoutDiscount - priceForDrinksWithoutDiscount * 0.35;
                        if (numberOfDrinks >= 5)
                        {
                            priceForDrinks -= priceForDrinks * 0.25; 
                        }
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    else if (sugar == "Normal")
                    {
                        priceForDrinks = numberOfDrinks * 1;
                        if (numberOfDrinks >= 5)
                        {
                            priceForDrinks -= priceForDrinks * 0.25;
                        }
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    else if (sugar == "Extra")
                    {
                        priceForDrinks = numberOfDrinks * 1.2;
                        if (numberOfDrinks >= 5)
                        {
                            priceForDrinks -= priceForDrinks * 0.25;
                        }
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        double priceForDrinksWithoutDiscount = numberOfDrinks * 1.0;
                        priceForDrinks = priceForDrinksWithoutDiscount - (priceForDrinksWithoutDiscount * 0.35);
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    else if (sugar == "Normal")
                    {
                        priceForDrinks = numberOfDrinks * 1.2;
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                            
                        }
                    }
                    else if (sugar == "Extra")
                    {
                        priceForDrinks = numberOfDrinks * 1.6;
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        double priceForDrinksWithoutDiscount = numberOfDrinks * 0.5;
                        priceForDrinks = priceForDrinksWithoutDiscount - (priceForDrinksWithoutDiscount * 0.35);
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    else if (sugar == "Normal")
                    {
                        priceForDrinks = numberOfDrinks * 0.6;
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    else if (sugar == "Extra")
                    {
                        priceForDrinks = numberOfDrinks * 0.7;
                        if (priceForDrinks > 15)
                        {
                            priceForDrinks -= priceForDrinks * 0.2;
                        }
                    }
                    break;
            }
            Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {priceForDrinks:f2} lv.");
        }
    }
}
