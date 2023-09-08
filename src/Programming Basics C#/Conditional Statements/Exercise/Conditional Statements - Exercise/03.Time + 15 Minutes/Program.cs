namespace _03.Time___15_Minutes
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;

            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }

            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:0#}");
        }
    }
}
