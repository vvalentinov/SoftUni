namespace _07.Food_Delivery
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double totalSum = (chickenMenus * 10.35) + (fishMenus * 12.4) + (vegetarianMenus * 8.15);
            double desertPrice = totalSum * 0.2;
            totalSum += desertPrice + 2.5;
            Console.WriteLine(totalSum);
        }
    }
}
