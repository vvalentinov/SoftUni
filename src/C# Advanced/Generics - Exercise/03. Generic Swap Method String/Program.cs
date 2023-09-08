namespace _03._Generic_Swap_Method_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIdx = indexes[0];
            int secondIdx = indexes[1];
            Box<string> box = new Box<string>(names);
            box.Swap(firstIdx, secondIdx);
            Console.WriteLine(box.ToString());
        }
    }
}
