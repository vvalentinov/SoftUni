namespace _05.Travelling
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minBudgetNeeded = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (minBudgetNeeded > savedMoney)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
