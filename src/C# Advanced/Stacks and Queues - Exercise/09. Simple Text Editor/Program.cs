﻿namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            stack.Push(builder.ToString());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "1":
                        builder.Append(input[1]);
                        stack.Push(builder.ToString());
                        break;
                    case "2":
                        int number = int.Parse(input[1]);
                        builder.Remove(builder.Length - number, number);
                        stack.Push(builder.ToString());
                        break;
                    case "3":
                        int index = int.Parse(input[1]);
                        Console.WriteLine(builder[index - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        builder = new StringBuilder();
                        builder.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}
