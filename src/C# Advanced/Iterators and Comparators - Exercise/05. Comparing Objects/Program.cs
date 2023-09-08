namespace _05._Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = parts[0];
                int age = int.Parse(parts[1]);
                string town = parts[2];
                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine());

            Person comparedPerson = people[n - 1];

            int countMatches = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(comparedPerson) == 0)
                {
                    countMatches++;
                }
            }

            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int countNonMatches = people.Count - countMatches;
                Console.WriteLine($"{countMatches} {countNonMatches} {people.Count}");
            }
        }
    }
}
