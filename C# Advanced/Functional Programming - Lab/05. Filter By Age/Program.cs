namespace _05._Filter_By_Age
{
    using System;

    public class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people[i] = new Person() { Name = parts[0], Age = int.Parse(parts[1]) };
            }
            string condition = Console.ReadLine();
            int targetAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> conditionDelegate = GetCondition(condition, targetAge);
            Action<Person> formatDelegate = PrintFormat(format);
            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    formatDelegate(person);
                }
            }
        }
        private static Action<Person> PrintFormat(string format)
        {
            switch (format)
            {
                case "name":
                    return x => Console.WriteLine($"{x.Name}");
                case "age":
                    return x => Console.WriteLine($"{x.Age}");
                case "name age":
                    return x => Console.WriteLine($"{x.Name} - {x.Age}");
                default:
                    return null;
            }
        }

        private static Func<Person, bool> GetCondition(string condition, int age)
        {
            return condition == "younger" ? x => x.Age < age : x => x.Age >= age;
        }
    }
}
