namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getSmallest = x => x.Min();
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(getSmallest(input));
        }
    }
}
