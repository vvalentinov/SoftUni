namespace _03._Oldest_Family_Member
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                int age = int.Parse(parts[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
