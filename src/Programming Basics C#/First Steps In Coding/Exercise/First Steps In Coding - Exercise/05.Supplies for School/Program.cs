namespace _05.Supplies_for_School
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double totalSum = (pens * 5.80) + (markers * 7.20) + (boardCleaner * 1.20);
            Console.WriteLine(totalSum - (totalSum * discount / 100));
        }
    }
}
