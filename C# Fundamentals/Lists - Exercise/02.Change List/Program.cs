namespace _02.Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0].ToUpper() != "END")
            {
                if (command[0].ToUpper() == "DELETE")
                {
                    numbers.RemoveAll(item => item == int.Parse(command[1]));
                }
                else if (command[0].ToUpper() == "INSERT")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
