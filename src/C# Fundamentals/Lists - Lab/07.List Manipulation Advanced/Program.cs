namespace _07.List_Manipulation_Advanced
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
            bool isChanged = false;
            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "CONTAINS":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "PRINTEVEN":
                        Console.WriteLine(string.Join(' ', numbers.Where(n => n % 2 == 0)));
                        break;
                    case "PRINTODD":
                        Console.WriteLine(string.Join(' ', numbers.Where(n => n % 2 != 0)));
                        break;
                    case "GETSUM":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "FILTER":
                        string result = string.Empty;
                        if (command[1] == "<")
                        {
                            result = string.Join(" ", numbers.Where(n => n < int.Parse(command[2])));
                        }
                        else if (command[1] == ">")
                        {
                            result = string.Join(" ", numbers.Where(n => n > int.Parse(command[2])));
                        }
                        else if (command[1] == "<=")
                        {
                            result = string.Join(" ", numbers.Where(n => n <= int.Parse(command[2])));
                        }
                        else if (command[1] == ">=")
                        {
                            result = string.Join(" ", numbers.Where(n => n >= int.Parse(command[2])));
                        }
                        Console.WriteLine(result);
                        break;
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
