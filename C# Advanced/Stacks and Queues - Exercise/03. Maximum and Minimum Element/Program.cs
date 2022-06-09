namespace _03._Maximum_and_Minimum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            if (n >= 1 && n <= 105)
            {
                for (int i = 0; i < n; i++)
                {
                    string line = Console.ReadLine();
                    if (line == "2")
                    {
                        if (stack.Count != 0)
                        {
                            stack.Pop();
                        }
                    }
                    else if (line == "3")
                    {
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                    }
                    else if (line == "4")
                    {
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                    }
                    else
                    {
                        string[] parts = line.Split();
                        int number = int.Parse(parts[1]);
                        if (number >= 1 && number <= 109)
                        {
                            stack.Push(number);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
