namespace _10._The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> filters = new List<string>();
            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand == "Print")
                {
                    break;
                }
                string[] tokens = inputCommand.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string commandName = tokens[0];
                string filterType = tokens[1];
                string argument = tokens[2];
                if (commandName == "Add filter")
                {
                    filters.Add($"{filterType};{argument}");
                }
                else if (commandName == "Remove filter")
                {
                    filters.Remove($"{filterType};{argument}");
                }
            }

            foreach (string filterLine in filters)
            {
                string[] tokens = filterLine.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string filterType = tokens[0];
                string argument = tokens[1];
                switch (filterType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        people = people.Where(p => p.Length != int.Parse(argument)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(argument)).ToList();
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', people));
        }
    }
}
