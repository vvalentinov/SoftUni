namespace _02.Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        class Family
        {
            public Family()
            {
                People = new List<Person>();
            }
            public List<Person> People { get; set; }

            public void AddMember(Family family, Person person)
            {
                family.People.Add(person);
            }
            public string GetOldestFamilyMember(Family family)
            {
                int maxAge = int.MinValue;
                string biggestPerson = string.Empty;
                foreach (var person in family.People)
                {
                    if (person.Age > maxAge)
                    {
                        maxAge = person.Age;
                        biggestPerson = person.Name;
                    }
                }
                return $"{biggestPerson} {maxAge}";
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string name = arr[0];
                int age = int.Parse(arr[1]);

                Person person = new Person()
                {
                    Name = name,
                    Age = age
                };

                family.AddMember(family, person);
            }

            Console.WriteLine(family.GetOldestFamilyMember(family));
        }
    }
}
