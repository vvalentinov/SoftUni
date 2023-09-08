namespace _02.Pounds_to_Dollars
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{pounds * 1.31M:f3}");
        }
    }
}
