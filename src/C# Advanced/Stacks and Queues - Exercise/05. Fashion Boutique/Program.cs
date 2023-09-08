namespace _05._Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            foreach (int item in clothes)
            {
                stack.Push(item);
            }
            int rack = 1;
            int sum = 0;
            while (stack.Count > 0)
            {
                int current = stack.Peek();
                if (current + sum < capacity)
                {
                    sum += current;
                    stack.Pop();
                }
                else if (current + sum == capacity)
                {
                    if (stack.Count == 1)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        rack++;
                        sum = 0;
                        stack.Pop();
                    }
                }
                else if (current + sum > capacity)
                {
                    sum = 0;
                    rack++;
                }
            }
            Console.WriteLine(rack);
        }
    }
}
