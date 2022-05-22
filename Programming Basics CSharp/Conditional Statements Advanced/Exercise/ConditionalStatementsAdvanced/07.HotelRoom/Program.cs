namespace _07.HotelRoom
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double totalSumStudio = 0;
            double totalSumApartment = 0;
            switch (month)
            {
                case "May":
                case "October":
                    if(numberOfNights > 14)
                    {
                        totalSumStudio = (50 - (50 * 0.3)) * numberOfNights;
                        totalSumApartment = (65 - (65 * 0.1)) * numberOfNights;
                    }
                    else if (numberOfNights > 7 || numberOfNights == 14)
                    {
                        totalSumStudio = (50 - (50 * 0.05)) * numberOfNights;
                        totalSumApartment = 65 * numberOfNights;
                    }
                    else
                    {
                        totalSumStudio = 50 * numberOfNights;
                        totalSumApartment = 65 * numberOfNights;
                    }
                    break;
                case "June":
                case "September":
                    if (numberOfNights > 14)
                    {
                        totalSumStudio = (75.2 - (75.2 * 0.2)) * numberOfNights;
                        totalSumApartment = (68.7 - (68.7 * 0.1)) * numberOfNights;
                    }
                    else
                    {
                        totalSumStudio = 75.2 * numberOfNights;
                        totalSumApartment = 68.7 * numberOfNights;
                    }
                    break;
                case "July":
                case "August":
                    if (numberOfNights > 14)
                    {
                        totalSumApartment = (77 - (77 * 0.1)) * numberOfNights;
                        totalSumStudio = 76 * numberOfNights;
                    }
                    else
                    {
                        totalSumApartment = 77 * numberOfNights;
                        totalSumStudio = 76 * numberOfNights;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {totalSumApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalSumStudio:f2} lv.");
        }
    }
}
