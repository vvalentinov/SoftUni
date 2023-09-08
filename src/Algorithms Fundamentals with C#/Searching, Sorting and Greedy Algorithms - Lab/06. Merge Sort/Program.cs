namespace _06._Merge_Sort
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

            int[] sorted = MergeSort(numbers);

            Console.WriteLine(string.Join(' ', sorted));
        }

        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            int[] left = numbers.Take(numbers.Length / 2).ToArray();
            int[] right = numbers.Skip(numbers.Length / 2).ToArray();

            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] merged = new int[left.Length + right.Length];

            int mergedIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    merged[mergedIndex++] = left[leftIndex++];
                }
                else
                {
                    merged[mergedIndex++] = right[rightIndex++];
                }
            }

            for (int i = leftIndex; i < left.Length; i++)
            {
                merged[mergedIndex++] = left[i];
            }

            for (int i = rightIndex; i < right.Length; i++)
            {
                merged[mergedIndex++] = right[i];
            }

            return merged;
        }
    }
}