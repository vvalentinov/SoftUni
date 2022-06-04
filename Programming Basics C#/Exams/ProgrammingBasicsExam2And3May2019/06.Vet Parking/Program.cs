namespace _06.Vet_Parking
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursADay = int.Parse(Console.ReadLine());

            double total = 0;
            for (int i = 1; i <= days; i++)
            {
                double tax = 0;
                for (int j = 1; j <= hoursADay; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        tax += 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        tax += 1.25;
                    }
                    else
                    {
                        tax += 1;
                    }

                }
                Console.WriteLine($"Day: {i} - {tax:f2} leva");
                total += tax;
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
