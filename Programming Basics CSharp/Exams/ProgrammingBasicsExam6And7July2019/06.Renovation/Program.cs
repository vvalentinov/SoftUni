namespace _06.Renovation
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int heigth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double totalArea = heigth * width * 4;
            double areaToBePaint = totalArea - totalArea * (percent * 1.0 / 100);
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Tired!")
                {
                    Console.WriteLine($"{areaToBePaint} quadratic m left.");
                    break;
                }
                int paintLitres = int.Parse(command);
                areaToBePaint = Math.Ceiling(areaToBePaint - paintLitres);
                if (areaToBePaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaToBePaint)} l paint left!");
                    break;
                }
                else if (areaToBePaint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
            }
        }
    }
}
