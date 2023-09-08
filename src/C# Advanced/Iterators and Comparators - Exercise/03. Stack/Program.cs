namespace _03._Stack
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                if (line == "Pop")
                {

                    if (stack.Count == 0)
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    string[] parts = line.Split();
                    string element = parts[1];
                    stack.Push(element);
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
