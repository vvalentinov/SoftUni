namespace _04._Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                int age = int.Parse(parts[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }
            List<Person> peopleSorted = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            foreach (Person person in peopleSorted)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
