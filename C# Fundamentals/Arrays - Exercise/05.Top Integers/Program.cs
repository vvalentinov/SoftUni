namespace _05.Top_Integers
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool isBigger = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currInt = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= currInt)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{currInt} ");
                }
                isBigger = true;
            }
        }
    }
}
