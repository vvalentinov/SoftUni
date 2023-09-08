namespace _01._Recursive_Array_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            Console.WriteLine(GetSum(numbers, 0));
        }
        private static int GetSum(int[] numbers, int index)
        {
            if (index >= numbers.Length - 1)
            {
                return numbers[index];
            }

            int result = GetSum(numbers, index + 1);

            return numbers[index] + result;
        }
    }
}
