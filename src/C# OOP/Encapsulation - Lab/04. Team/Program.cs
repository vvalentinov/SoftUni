namespace _04._Team
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                Person person = new Person(parts[0], parts[1], int.Parse(parts[2]), decimal.Parse(parts[3]));
                people.Add(person);
            }

            Team team = new Team("SoftUni");
            foreach (Person person in people)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
