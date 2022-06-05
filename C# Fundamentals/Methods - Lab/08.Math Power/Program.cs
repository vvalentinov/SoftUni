namespace _08.Math_Power
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(NumberPowered(number, power));
        }
        private static double NumberPowered(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
