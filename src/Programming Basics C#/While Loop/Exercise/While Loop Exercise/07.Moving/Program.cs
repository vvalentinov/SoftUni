namespace _07.Moving
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heigthFreeSpace = int.Parse(Console.ReadLine());

            int totalFreeSpace = widthFreeSpace * lengthFreeSpace * heigthFreeSpace;
            string input = Console.ReadLine();
            while (input != "Done" && totalFreeSpace >= 0)
            {
                int boxes = int.Parse(input);
                totalFreeSpace -= boxes;
                input = Console.ReadLine();
            }
            if (totalFreeSpace < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(totalFreeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{totalFreeSpace} Cubic meters left.");
            }
        }
    }
}
