namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicals = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string chemical in parts)
                {
                    chemicals.Add(chemical);
                }
            }
            Console.WriteLine(string.Join(' ', chemicals));
        }
    }
}
