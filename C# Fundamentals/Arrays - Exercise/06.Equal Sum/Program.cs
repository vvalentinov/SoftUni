﻿namespace _06.Equal_Sum
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            for (int curr = 0; curr < arr.Length; curr++)
            {
                int sumRight = 0;
                for (int i = curr + 1; i < arr.Length; i++)
                {
                    sumRight += arr[i];
                }
                int sumLeft = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    sumLeft += arr[i];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
