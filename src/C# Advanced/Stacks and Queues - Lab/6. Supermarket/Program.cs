namespace _6._Supermarket
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();
            while (true)
            {
                string person = Console.ReadLine();
                if (person == "End")
                {
                    break;
                }

                if (person == "Paid")
                {
                    foreach (var item in people)
                    {
                        Console.WriteLine(item);
                    }

                    people.Clear();

                    continue;
                }

                people.Enqueue(person);
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
