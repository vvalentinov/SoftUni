namespace _06._Reverse_And_Exclude
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
                .Reverse()
                .ToArray();
            int num = int.Parse(Console.ReadLine());
            Func<int, bool> divisible = CheckIfDivisible(num);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!divisible(numbers[i]))
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
        private static Func<int, bool> CheckIfDivisible(int num)
        {
            return x => x % num == 0;
        }
    }
}
