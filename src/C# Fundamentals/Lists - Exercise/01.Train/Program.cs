namespace _01.Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgument = command.Split();
                if (commandArgument[0] == "Add")
                {
                    wagons.Add(int.Parse(commandArgument[1]));
                }
                else
                {
                    int passengers = int.Parse(commandArgument[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currWagon = wagons[i];
                        bool isEnoughSpace = currWagon + passengers <= maxCapacity;
                        if (isEnoughSpace)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
