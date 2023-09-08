namespace _07.Equal_Arrays
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    int curr = arr1[i];
                    sum += curr;
                }
            }
            if (arr1.SequenceEqual(arr2))
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
