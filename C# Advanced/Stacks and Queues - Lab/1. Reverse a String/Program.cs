namespace _1._Reverse_a_String
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            string result = string.Empty;
            while (stack.Count != 0)
            {
                result += stack.Pop();
            }
            Console.WriteLine(result);
        }
    }
}
