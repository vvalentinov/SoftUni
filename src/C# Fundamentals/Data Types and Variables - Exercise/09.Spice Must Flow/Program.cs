namespace _09.Spice_Must_Flow
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalSpice = 0;
            int countDays = 0;
            if (yield >= 100)
            {
                do
                {
                    int spice = yield - 26;
                    if (yield >= 100)
                    {
                        totalSpice += spice;
                        yield -= 10;
                        countDays++;
                    }
                } while (yield >= 100);
                if (yield >= 26)
                {
                    totalSpice -= 26;
                }
                Console.WriteLine(countDays);
                Console.WriteLine(totalSpice);
            }
            else
            {
                Console.WriteLine(countDays);
                Console.WriteLine(totalSpice);
            }
        }
    }
}
