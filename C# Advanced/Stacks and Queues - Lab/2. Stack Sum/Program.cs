namespace _2._Stack_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>();
            foreach (int number in numbers)
            {
                stack.Push(number);
            }

            while (true)
            {
                string line = Console.ReadLine().ToLower();
                if (line == "end")
                {
                    break;
                }
                string[] parts = line.Split();
                string command = parts[0];
                if (command == "add")
                {
                    int first = int.Parse(parts[1]);
                    int second = int.Parse(parts[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                else
                {
                    int count = int.Parse(parts[1]);
                    if (count > stack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
