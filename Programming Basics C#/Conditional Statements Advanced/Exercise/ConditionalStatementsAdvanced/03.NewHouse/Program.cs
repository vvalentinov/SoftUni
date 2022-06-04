namespace _03.NewHouse
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = numberOfFlowers;
            double money = 0;
            bool budgetIsEnough = true;

            switch (typeOfFlower)
            {
                case "Roses":
                    if (numberOfFlowers > 80)
                    {
                        price *= 5;
                        price -= price * 0.1;
                        if (price <= budget)
                        {
                            money = budget - price;

                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    else
                    {
                        price *= 5;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    break;
                case "Dahlias":
                    if (numberOfFlowers > 90)
                    {
                        price *= 3.8;
                        price -= price * 0.15;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    else
                    {
                        price *= 3.8;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    break;
                case "Tulips":
                    if (numberOfFlowers > 80)
                    {
                        price *= 2.8;
                        price -= price * 0.15;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    else
                    {
                        price *= 2.8;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    break;
                case "Narcissus":
                    if (numberOfFlowers < 120)
                    {
                        price *= 3;
                        price += price * 0.15;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    else
                    {
                        price *= 3;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    break;
                case "Gladiolus":
                    if (numberOfFlowers < 80)
                    {
                        price *= 2.5;
                        price += price * 0.2;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    else
                    {
                        price *= 2.5;
                        if (price <= budget)
                        {
                            money = budget - price;
                        }
                        else
                        {
                            money = price - budget;
                            budgetIsEnough = false;
                        }
                    }
                    break;
            }
            if (budgetIsEnough)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {money:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {money:f2} leva more.");
            }  
        }
    }
}
