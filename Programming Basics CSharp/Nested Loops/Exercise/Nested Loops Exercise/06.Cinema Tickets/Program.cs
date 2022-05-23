namespace _06.Cinema_Tickets
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int studentTicketsCount = 0;
            int standardTicketsCount = 0;
            int kidTicketsCount = 0;

            int totalTicketsCount = 0;
            while (movie != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                int currentStudentTicketsCount = 0;
                int currentStandardTicketsCount = 0;
                int currentKidTicketsCount = 0;

                for (int i = 0; i < seats; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    totalTicketsCount++;
                    switch (ticketType)
                    {
                        case "standard":
                            currentStandardTicketsCount++;
                            standardTicketsCount++;
                            break;
                        case "student":
                            currentStudentTicketsCount++;
                            studentTicketsCount++;
                            break;
                        case "kid":
                            currentKidTicketsCount++;
                            kidTicketsCount++;
                            break;
                    }
                }

                Console.WriteLine($"{movie} - {(currentStandardTicketsCount + currentStudentTicketsCount + currentKidTicketsCount) * 1.0 / seats * 100:f2}% full.");
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentTicketsCount * 1.0 / totalTicketsCount * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsCount * 1.0 / totalTicketsCount * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsCount * 1.0 / totalTicketsCount * 100:f2}% kids tickets.");
        }
    }
}
