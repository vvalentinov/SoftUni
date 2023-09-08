namespace _06.Calculate_Rectangle_Area
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(width, length));
        }
        private static int RectangleArea(int width, int length)
        {
            return width * length;
        }
    }
}
