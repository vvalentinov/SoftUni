namespace _5._Print_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    queue.Enqueue(integers[i]);
                }
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
