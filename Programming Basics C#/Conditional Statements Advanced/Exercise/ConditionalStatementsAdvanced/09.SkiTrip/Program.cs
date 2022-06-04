namespace _09.SkiTrip
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            days -= 1;
            double sum = days;
            switch (roomType)
            {
                case "room for one person":
                    sum *= 18;
                    break;
                case "apartment":
                    sum *= 25;
                    if (days < 10)
                    {
                        sum -= sum * 0.3;
                    }
                    else if (days >=10 && days <= 15)
                    {
                        sum -= sum * 0.35;
                    }
                    else
                    {
                        sum -= sum * 0.5;
                    }
                    break;
                case "president apartment":
                    sum *= 35;
                    if (days < 10)
                    {
                        sum -= sum * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        sum -= sum * 0.15;
                    }
                    else
                    {
                        sum -= sum * 0.2;
                    }
                    break;
            }

            sum = feedback == "positive" ? sum + (sum * 0.25) : sum - (sum * 0.1);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
