namespace _01._Define_a_Class_Person
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Pesho";
            person.Age = 20;
            Console.WriteLine($"{person.Name} {person.Age}");
            Person person2 = new Person("Gosho", 18);
            Console.WriteLine($"{person2.Name} {person2.Age}");
            Person person3 = new Person()
            {
                Name = "Stamat",
                Age = 43
            };
            Console.WriteLine($"{person3.Name} {person3.Age}");
        }
    }
}
