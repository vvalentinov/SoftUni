namespace _04.Travel_Agency
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string packet = Console.ReadLine();
            string discount = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());

            double priceForDay = 0;
            double totalPrice = 0;
            bool isValidInput = true;

            if (numberOfDays < 1)
            {
                Console.WriteLine("Days must be positive number!");
                isValidInput = false;
            }
            else
            {
                switch (town)
                {
                    case "Bansko":
                    case "Borovets":
                        if (packet == "withEquipment")
                        {
                            priceForDay = 100;
                            if (discount == "yes")
                            {
                                priceForDay -= priceForDay * 0.1;
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                            else if (discount == "no")
                            {
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                        }
                        else if (packet == "noEquipment")
                        {
                            priceForDay = 80;
                            if (discount == "yes")
                            {
                                priceForDay -= priceForDay * 0.05;
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                            else if (discount == "no")
                            {
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;                               
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                        }
                        else
                        {
                            isValidInput = false;
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "Varna":
                    case "Burgas":
                        if (packet == "withBreakfast")
                        {
                            priceForDay = 130;
                            if (discount == "yes")
                            {
                                priceForDay -= priceForDay * 0.12;
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                            else if (discount == "no")
                            {
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;                
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                        }
                        else if (packet == "noBreakfast")
                        {
                            priceForDay = 100;
                            if (discount == "yes")
                            {
                                priceForDay -= priceForDay * 0.07;
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                            else if (discount == "no")
                            {
                                if (numberOfDays > 7)
                                {
                                    numberOfDays--;
                                }
                                totalPrice = numberOfDays * priceForDay;
                            }
                        }
                        else
                        {
                            isValidInput = false;
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        isValidInput = false;
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            if (isValidInput)
            {
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }
        }
    }
}
