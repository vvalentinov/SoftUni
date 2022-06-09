namespace _07._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numPumps = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < numPumps; i++)
            {
                string line = Console.ReadLine();
                line += $" {i}";
                queue.Enqueue(line);
            }
            int totalFuel = 0;
            for (int i = 0; i < numPumps; i++)
            {
                string current = queue.Dequeue();
                int[] info = current.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int petrol = info[0];
                int distance = info[1];
                totalFuel += petrol;
                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }
                queue.Enqueue(current);
            }
            string pump = queue.Dequeue();
            int[] pumpInfo = pump.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index = pumpInfo[2];
            Console.WriteLine(index);
        }
    }
}
