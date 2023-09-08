namespace _07.Area_of_Figures
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            switch (figure)
            {
                case "square":
                    double squareArea = a * a;
                    Console.WriteLine($"{squareArea:f3}");
                    break;
                case "rectangle":
                    double b = double.Parse(Console.ReadLine());
                    double rectangleArea = a * b;
                    Console.WriteLine($"{rectangleArea:f3}");
                    break;
                case "circle":
                    double circleArea = Math.PI * a * a;
                    Console.WriteLine($"{circleArea:f3}");
                    break;
                case "triangle":
                    double h = double.Parse(Console.ReadLine());
                    double triangleArea = (a * h) / 2;
                    Console.WriteLine($"{triangleArea:f3}");
                    break;
            }
        }
    }
}
