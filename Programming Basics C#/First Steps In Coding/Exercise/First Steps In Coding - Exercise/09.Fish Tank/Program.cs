namespace _09.Fish_Tank
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volumeOfTank = length * width * heigth;
            double litresInTank = volumeOfTank * 0.001;
            double percentForOtherThings = percent / 100;
            double realLitresInTank = litresInTank * (1 - percentForOtherThings);
            Console.WriteLine(realLitresInTank);
        }
    }
}
