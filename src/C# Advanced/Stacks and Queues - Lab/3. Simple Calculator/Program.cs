namespace _3._Simple_Calculator
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string input = Console.ReadLine();
            string[] arr = input.Split();
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                stack.Push(item);
            }
            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());
                if (sign == "+")
                {
                    stack.Push((first + second).ToString());
                }
                else
                {
                    stack.Push((first - second).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
