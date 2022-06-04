namespace _07.Water_Overflow
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (litres > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= litres;
                    sum += litres;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
