namespace _06.Cinema_Tickets
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int totalTickets = 0;
            int countStudentTickets = 0;
            int countStandardTickets = 0;
            int countKidTickets = 0;
            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int currentSoldTickets = 0;
                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();
                    bool breakPoint = false;
                    switch (ticketType)
                    {
                        case "student":
                            countStudentTickets++;
                            break;
                        case "standard":
                            countStandardTickets++;
                            break;
                        case "kid":
                            countKidTickets++;
                            break;
                        default:
                            breakPoint = true;
                            break;
                    }
                    if (breakPoint)
                    {
                        break;
                    }
                    currentSoldTickets++;
                    totalTickets++;
                }
                Console.WriteLine($"{movieName} - {currentSoldTickets * 1.0 / freeSeats * 100:f2}% full.");
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{countStudentTickets * 1.0 / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{countStandardTickets * 1.0 / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{countKidTickets * 1.0 / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
