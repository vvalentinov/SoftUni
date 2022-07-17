namespace _02._Dividing_Presents
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] presents = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            Dictionary<int, int> allSums = FindAllSums(presents);

            int totalSum = presents.Sum();

            int alanSum = totalSum / 2;

            while (true)
            {
                if (allSums.ContainsKey(alanSum))
                {
                    List<int> alanPresensts = FindSubset(allSums, alanSum);
                    int bobSum = totalSum - alanSum;

                    Console.WriteLine($"Difference: {bobSum - alanSum}");
                    Console.WriteLine($"Alan:{alanSum} Bob:{bobSum}");
                    Console.WriteLine($"Alan takes: {string.Join(' ', alanPresensts)}");
                    Console.WriteLine("Bob takes the rest.");

                    break;
                }

                alanSum--;
            }
        }

        private static List<int> FindSubset(Dictionary<int, int> sums, int target)
        {
            List<int> subset = new List<int>();

            while (target != 0)
            {
                var element = sums[target];
                subset.Add(element);

                target -= element;
            }

            return subset;
        }

        private static Dictionary<int, int> FindAllSums(int[] elements)
        {
            Dictionary<int, int> sums = new Dictionary<int, int> { { 0, 0 } };

            foreach (int element in elements)
            {
                int[] currentSums = sums.Keys.ToArray();

                foreach (int sum in currentSums)
                {
                    int newSum = sum + element;

                    if (sums.ContainsKey(newSum))
                    {
                        continue;
                    }

                    sums.Add(newSum, element);
                }
            }

            return sums;
        }
    }
}