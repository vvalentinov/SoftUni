namespace _02._Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>();
            int N = input[0];
            int S = input[1];
            int X = input[2];
            foreach (int number in numbers)
            {
                queue.Enqueue(number);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
