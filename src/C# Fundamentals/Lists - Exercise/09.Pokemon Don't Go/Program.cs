namespace _09.Pokemon_Don_t_Go
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (input.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    int removed = input[0];
                    sum += removed;
                    input[0] = input[input.Count - 1];
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removed)
                        {
                            input[i] += removed;
                        }
                        else
                        {
                            input[i] -= removed;
                        }
                    }
                }
                else if (index > input.Count - 1)
                {
                    int removed = input[input.Count - 1];
                    sum += removed;
                    input[input.Count - 1] = input[0];
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removed)
                        {
                            input[i] += removed;
                        }
                        else
                        {
                            input[i] -= removed;
                        }
                    }
                }
                else
                {
                    int removed = input[index];
                    sum += removed;
                    input.RemoveAt(index);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removed)
                        {
                            input[i] += removed;
                        }
                        else
                        {
                            input[i] -= removed;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
