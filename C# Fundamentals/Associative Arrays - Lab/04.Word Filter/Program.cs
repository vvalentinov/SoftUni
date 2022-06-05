﻿namespace _04.Word_Filter
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
