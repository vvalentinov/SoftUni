namespace _02._Sum_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            PrintResult(arr, GetCount, GetSum);
        }
        private static int GetCount(int[] array)
        {
            return array.Length;
        }

        private static int GetSum(int[] array)
        {
            return array.Sum();
        }
        private static void PrintResult(int[] arr, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(count(arr));
            Console.WriteLine(sum(arr));
        }
    }
}
