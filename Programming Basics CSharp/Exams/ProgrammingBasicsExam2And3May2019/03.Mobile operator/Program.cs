namespace _03.Mobile_operator
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string termContract = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int numberOfMonths = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            if (termContract == "one")
            {
                double monthTax = 0;
                if (typeContract == "Small")
                {
                    monthTax = internet == "yes" ? 9.98 + 5.5 : 9.98;
                }
                else if (typeContract == "Middle")
                {
                    monthTax = internet == "yes" ? 18.99 + 4.35 : 18.99;
                }
                else if (typeContract == "Large")
                {
                    monthTax = internet == "yes" ? 25.98 + 4.35 : 25.98;
                }
                else if (typeContract == "ExtraLarge")
                {
                    monthTax = internet == "yes" ? 35.99 + 3.85 : 35.99;
                }
                totalMoney = numberOfMonths * monthTax;
            }
            else if (termContract == "two")
            {
                if (typeContract == "Small")
                {
                    double monthTax = 8.58;
                    if (internet == "yes")
                    {
                        monthTax += 5.50;
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                    else if (internet == "no")
                    {
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                }
                else if (typeContract == "Middle")
                {
                    double monthTax = 17.09;
                    if (internet == "yes")
                    {
                        monthTax += 4.35;
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                    else if (internet == "no")
                    {
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                }
                else if (typeContract == "Large")
                {
                    double monthTax = 23.59;
                    if (internet == "yes")
                    {
                        monthTax += 4.35;
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                    else if (internet == "no")
                    {
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                }
                else if (typeContract == "ExtraLarge")
                {
                    double monthTax = 31.79;
                    if (internet == "yes")
                    {
                        monthTax += 3.85;
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                    else if (internet == "no")
                    {
                        double money = numberOfMonths * monthTax;
                        totalMoney = money - 0.0375 * money;
                    }
                }
            }
            Console.WriteLine($"{totalMoney:f2} lv.");
        }
    }
}
