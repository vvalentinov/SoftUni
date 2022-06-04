namespace _01.Convert_Meters_to_Kilometers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            Console.WriteLine($"{meters / 1000.0M:f2}");
        }
    }
}
