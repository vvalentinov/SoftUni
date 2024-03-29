﻿namespace _04.Array_Rotation
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string elementToRotate = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    string currElement = arr[j];
                    arr[j - 1] = currElement;
                }
                arr[arr.Length - 1] = elementToRotate;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
