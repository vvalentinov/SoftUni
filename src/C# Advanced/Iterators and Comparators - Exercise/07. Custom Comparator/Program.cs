namespace _07._Custom_Comparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Comparer<int> customComparer = Comparer<int>.Create((a, b) =>
            {
                if (Math.Abs(a) % 2 == 0 && Math.Abs(b) % 2 == 1)
                {
                    return -1;
                }
                else if (Math.Abs(a) % 2 == 1 && Math.Abs(b) % 2 == 0)
                {
                    return 1;
                }   
                else
                {
                    return a.CompareTo(b);
                }     
            });


            Array.Sort(numbers, customComparer);

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
