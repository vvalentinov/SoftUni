namespace _03.Oscars_Week_In_Cinema
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string room = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());

            double priceForTicket = 0;
            switch (movie)
            {
                case "A Star Is Born":
                    if (room == "normal")
                    {
                        priceForTicket = 7.5;
                    }
                    else if (room == "luxury")
                    {
                        priceForTicket = 10.5;
                    }
                    else if (room == "ultra luxury")
                    {
                        priceForTicket = 13.5;
                        
                    }
                    break;
                case "Bohemian Rhapsody":
                    if (room == "normal")
                    {
                        priceForTicket = 7.35;
                    }
                    else if (room == "luxury")
                    {
                        priceForTicket = 9.45;
                    }
                    else if (room == "ultra luxury")
                    {
                        priceForTicket = 12.75;
                    }
                    break;
                case "Green Book":
                    if (room == "normal")
                    {
                        priceForTicket = 8.15;
                    }
                    else if (room == "luxury")
                    {
                        priceForTicket = 10.25;
                    }
                    else if (room == "ultra luxury")
                    {
                        priceForTicket = 13.25;
                    }
                    break;
                case "The Favourite":
                    if (room == "normal")
                    {
                        priceForTicket = 8.75;
                    }
                    else if (room == "luxury")
                    {
                        priceForTicket = 11.55;
                    }
                    else if (room == "ultra luxury")
                    {
                        priceForTicket = 13.95;
                    }
                    break;
            }
            Console.WriteLine($"{movie} -> {numberOfTickets * priceForTicket:f2} lv.");
        }
    }
}
