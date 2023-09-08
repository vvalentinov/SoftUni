namespace _01.Cinema
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double totalIncomeFromTickets = rows * columns;
            switch (projection)
            {
                case "Premiere":
                    totalIncomeFromTickets *= 12;
                    break;
                case "Normal":
                    totalIncomeFromTickets *= 7.5;
                    break;
                case "Discount":
                    totalIncomeFromTickets *= 5;
                    break;
            }
            Console.WriteLine($"{totalIncomeFromTickets:f2} leva");
        }
    }
}
