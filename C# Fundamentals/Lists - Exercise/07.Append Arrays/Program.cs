namespace _07.Append_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                                      .Split("|")
                                      .ToList();
            items.Reverse();
            List<string> result = new List<string>();
            foreach (string currItem in items)
            {
                string[] numbers = currItem.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
