namespace _01._Binary_Search
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(numbers, number));
        }

        private static int BinarySearch(int[] numbers, int number)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (numbers[mid] == number)
                {
                    return mid;
                }

                if (number > numbers[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}