namespace _01.Sort_Numbers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);

            Console.WriteLine(max);
            if (a != max && a != min)
            {
                Console.WriteLine(a);
            }
            else if (b != max && b != min)
            {
                Console.WriteLine(b);
            }
            else if (c != max && c != min)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(min);
            }
            Console.WriteLine(min);
        }
    }
}
