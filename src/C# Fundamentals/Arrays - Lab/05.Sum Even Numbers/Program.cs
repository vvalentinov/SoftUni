namespace _05.Sum_Even_Numbers
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                if (curr % 2 == 0)
                {
                    sum += curr;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
