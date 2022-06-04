namespace _02.Common_Elements
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            for (int j = 0; j < arr2.Length; j++)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr2[j] == arr1[i])
                    {
                        Console.Write($"{arr2[j]} ");
                    }
                }
            }
        }
    }
}
