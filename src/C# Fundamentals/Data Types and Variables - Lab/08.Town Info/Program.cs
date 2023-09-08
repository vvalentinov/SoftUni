namespace _08.Town_Info
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            ulong population = ulong.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
