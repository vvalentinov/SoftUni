namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(bottlesData);
            Queue<int> cups = new Queue<int>(cupsData);
            int wastedWater = 0;
            while (bottles.Count > 0 && cups.Count > 0)
            {
                int cup = cups.Peek();
                int bottle = bottles.Peek();
                if (bottle > cup)
                {
                    bottle -= cup;
                    wastedWater += bottle;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else if (bottle == cup)
                {
                    bottles.Pop();
                    cups.Dequeue();
                }
                else
                {
                    cup -= bottle;
                    bottles.Pop();
                    ModifyCups(cups, cup);
                }
            }
            if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
        private static void ModifyCups(Queue<int> cups, int cup)
        {
            List<int> cupsInfo = new List<int>();
            cups.Dequeue();
            while (cups.Count > 0)
            {
                int currCup = cups.Dequeue();
                cupsInfo.Add(currCup);
            }
            cups.Enqueue(cup);
            foreach (int item in cupsInfo)
            {
                cups.Enqueue(item);
            }
        }
    }
}
