namespace _07.TrekkingMania
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsNumber = int.Parse(Console.ReadLine());

            int totalPeople = 0;
            int musallaPeople = 0;
            int monblanPeople = 0;
            int kilimandjaroPeople = 0;
            int kTwoPeople = 0;
            int everestPeople = 0;

            for (int i = 0; i < groupsNumber; i++)
            {
                int peopleInGroupNumber = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroupNumber;
                if (peopleInGroupNumber <= 5)
                {
                    musallaPeople += peopleInGroupNumber;
                }
                else if (peopleInGroupNumber >= 6 && peopleInGroupNumber <= 12)
                {
                    monblanPeople += peopleInGroupNumber;
                }
                else if (peopleInGroupNumber >= 13 && peopleInGroupNumber <= 25)
                {
                    kilimandjaroPeople += peopleInGroupNumber;
                }
                else if (peopleInGroupNumber >=26 && peopleInGroupNumber <= 40)
                {
                    kTwoPeople += peopleInGroupNumber;
                }
                else
                {
                    everestPeople += peopleInGroupNumber;
                }
            }
            Console.WriteLine($"{musallaPeople * 1.0 / totalPeople * 100:f2}%");
            Console.WriteLine($"{monblanPeople * 1.0 / totalPeople * 100:f2}%");
            Console.WriteLine($"{kilimandjaroPeople * 1.0 / totalPeople * 100:f2}%");
            Console.WriteLine($"{kTwoPeople * 1.0 / totalPeople * 100:f2}%");
            Console.WriteLine($"{everestPeople * 1.0 / totalPeople * 100:f2}%");
        }
    }
}
