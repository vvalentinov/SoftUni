namespace _06._Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Person> peopleHashSet = new HashSet<Person>();
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                int age = int.Parse(parts[1]);
                Person person = new Person(name, age);
                peopleHashSet.Add(person);
                peopleSortedSet.Add(person);
            }
            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
