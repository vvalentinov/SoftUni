namespace _09._Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Party!")
                {
                    break;
                }
                string[] parts = line.Split();
                string command = parts[0];
                string condition = parts[1];
                string value = parts[2];
                switch (command)
                {
                    case "Remove":
                        if (condition == "StartsWith")
                        {
                            people.RemoveAll(x => x.StartsWith(value));
                        }
                        else if (condition == "EndsWith")
                        {
                            people.RemoveAll(x => x.EndsWith(value));
                        }
                        else
                        {
                            people.RemoveAll(x => x.Length == int.Parse(value));
                        }
                        break;
                    case "Double":
                        if (condition == "StartsWith")
                        {
                            List<string> startsWith = people.Where(x => x.StartsWith(value)).ToList();
                            int index = people.FindIndex(x => x.StartsWith(value));
                            if (index != -1)
                            {
                                people.InsertRange(index, startsWith);
                            }
                        }
                        else if (condition == "EndsWith")
                        {
                            List<string> endsWith = people.Where(x => x.EndsWith(value)).ToList();
                            int index = people.FindIndex(x => x.EndsWith(value));
                            if (index != -1)
                            {
                                people.InsertRange(index, endsWith);
                            }
                        }
                        else
                        {
                            List<string> doubleLenght = people.Where(x => x.Length == int.Parse(value)).ToList();
                            int index = people.FindIndex(x => x.Length == int.Parse(value));
                            if (index != -1)
                            {
                                people.InsertRange(index, doubleLenght);
                            }
                        }
                        break;
                }


            }

            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
        }
    }
}
