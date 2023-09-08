namespace _04._Find_Evens_or_Odds
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int start = input[0];
            int end = input[1];
            string condition = Console.ReadLine();
            Predicate<int> predicate = CheckNumber(condition);
            for (int i = start; i <= end; i++)
            {
                if (predicate(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
        private static Predicate<int> CheckNumber(string condition)
        {
            if (condition == "odd")
            {
                return x => x % 2 != 0;
            }
            else
            {
                return x => x % 2 == 0;
            }
        }
    }
}
