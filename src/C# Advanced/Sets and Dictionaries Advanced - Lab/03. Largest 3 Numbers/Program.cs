namespace _03._Largest_3_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int[] orderedNumbers = numbers.OrderByDescending(x => x).ToArray();
            int maxIdx = 2;
            if (orderedNumbers.Length < 3)
            {
                maxIdx = orderedNumbers.Length - 1;
            }
            for (int i = 0; i < maxIdx + 1; i++)
            {
                Console.Write($"{orderedNumbers[i]} ");
            }
        }
    }
}
