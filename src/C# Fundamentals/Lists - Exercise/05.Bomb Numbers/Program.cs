﻿namespace _05.Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            int[] bombProp = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
            int bomb = bombProp[0];
            int power = bombProp[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNumber = numbers[i];
                if (currNumber == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    int endIndexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToRemove);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
