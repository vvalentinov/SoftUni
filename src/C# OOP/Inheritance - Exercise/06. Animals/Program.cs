namespace _06._Animals
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string animal = Console.ReadLine();
                if (animal == "Beast!")
                {
                    break;
                }
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string gender = parts[2];
                if (age <= 0 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                switch (animal)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        animals.Add(kitten);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
