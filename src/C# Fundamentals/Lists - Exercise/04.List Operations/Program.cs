namespace _04.List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArg = input.Split();

                if (cmdArg[0] == "Add")
                {
                    numbers.Add(int.Parse(cmdArg[1]));
                }
                else if (cmdArg[0] == "Insert")
                {
                    if (IsValidIndex(int.Parse(cmdArg[2]), numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(cmdArg[2]), int.Parse(cmdArg[1]));
                    }
                }
                else if (cmdArg[0] == "Remove")
                {
                    if (IsValidIndex(int.Parse(cmdArg[1]), numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(cmdArg[1]));
                    }
                }
                else if (cmdArg[0] == "Shift")
                {
                    if (cmdArg[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(cmdArg[2]); i++)
                        {
                            int firstElement = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(cmdArg[2]); i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastElement;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static bool IsValidIndex(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}
