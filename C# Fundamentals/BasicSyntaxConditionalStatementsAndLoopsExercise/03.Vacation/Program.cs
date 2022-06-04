namespace _03.Vacation
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;
            switch (group)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        totalPrice = number * 8.45;
                        if (number >= 30)
                        {
                            totalPrice -= totalPrice * 0.15;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = number * 9.8;
                        if (number >= 30)
                        {
                            totalPrice -= totalPrice * 0.15;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = number * 10.46;
                        if (number >= 30)
                        {
                            totalPrice -= totalPrice * 0.15;
                        }
                    }
                    break;
                case "Business":
                    if (number >= 100)
                    {
                        number -= 10;
                        if (day == "Friday")
                        {
                            totalPrice = number * 10.9;
                        }
                        else if (day == "Saturday")
                        {
                            totalPrice = number * 15.6;
                        }
                        else if (day == "Sunday")
                        {
                            totalPrice = number * 16;
                        }
                    }
                    else
                    {
                        if (day == "Friday")
                        {
                            totalPrice = number * 10.9;
                        }
                        else if (day == "Saturday")
                        {
                            totalPrice = number * 15.6;
                        }
                        else if (day == "Sunday")
                        {
                            totalPrice = number * 16;
                        }
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        totalPrice = number * 15;
                        if (number >= 10 && number <= 20)
                        {
                            totalPrice -= totalPrice * 0.05;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = number * 20;
                        if (number >= 10 && number <= 20)
                        {
                            totalPrice -= totalPrice * 0.05;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = number * 22.5;
                        if (number >= 10 && number <= 20)
                        {
                            totalPrice -= totalPrice * 0.05;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
