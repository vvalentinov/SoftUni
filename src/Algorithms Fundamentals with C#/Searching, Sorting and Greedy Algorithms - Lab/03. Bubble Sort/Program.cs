﻿namespace _03._Bubble_Sort
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            BubbleSort(numbers);

            Console.WriteLine(string.Join(' ', numbers));
        }

        private static void BubbleSort(int[] numbers)
        {
            int sortedCount = 0;
            bool isSorted = false;

            while (isSorted == false)
            {
                isSorted = true;

                for (int j = 1; j < numbers.Length - sortedCount; j++)
                {
                    int i = j - 1;

                    if (numbers[i] > numbers[j])
                    {
                        Swap(numbers, i, j);
                        isSorted = false;
                    }
                }

                sortedCount += 1;
            }
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            int temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}