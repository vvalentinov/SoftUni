namespace _04.Sum_with_Limited_Coins
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(CountSum(numbers, target));
        }

        private static int CountSum(int[] numbers, int target)
        {
            int counter = 0;
            HashSet<int> sums = new HashSet<int> { 0 };

            foreach (var number in numbers)
            {
                HashSet<int> newSums = new HashSet<int>();

                foreach (var sum in sums)
                {
                    int newSum = sum + number;

                    if (newSum == target)
                    {
                        counter++;
                    }

                    newSums.Add(newSum);
                }

                sums.UnionWith(newSums);
            }

            return counter;
        }
    }
}