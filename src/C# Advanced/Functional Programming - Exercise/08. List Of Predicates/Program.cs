namespace _08._List_Of_Predicates
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();
            for (int i = 1; i <= n; i++)
            {
                Func<int[], bool> func = x =>
                {
                    foreach (int number in x)
                    {
                        if (i % number != 0)
                        {
                            return false;
                        }
                    }
                    return true;
                };
                if (func(numbers))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
