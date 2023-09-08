namespace _04._Generic_Swap_Method_Integer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> values = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                values.Add(number);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIdx = indexes[0];
            int secondIdx = indexes[1];
            Box<int> box = new Box<int>(values);
            box.Swap(firstIdx, secondIdx);
            Console.WriteLine(box.ToString());
        }
    }
}
