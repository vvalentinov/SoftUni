namespace _11.Fruit_Shop
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                double price = 0;
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.5;
                        break;
                    case "apple":
                        price = quantity * 1.2;
                        break;
                    case "orange":
                        price = quantity * 0.85;
                        break;
                    case "grapefruit":
                        price = quantity * 1.45;
                        break;
                    case "kiwi":
                        price = quantity * 2.7;
                        break;
                    case "pineapple":
                        price = quantity * 5.5;
                        break;
                    case "grapes":
                        price = quantity * 3.85;
                        break;
                }
                if (price == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine($"{price:f2}");
                } 
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                double price = 0;
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.7;
                        break;
                    case "apple":
                        price = quantity * 1.25;
                        break;
                    case "orange":
                        price = quantity * 0.9;
                        break;
                    case "grapefruit":
                        price = quantity * 1.6;
                        break;
                    case "kiwi":
                        price = quantity * 3;
                        break;
                    case "pineapple":
                        price = quantity * 5.60;
                        break;
                    case "grapes":
                        price = quantity * 4.2;
                        break;
                }
                if (price == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine($"{price:f2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
