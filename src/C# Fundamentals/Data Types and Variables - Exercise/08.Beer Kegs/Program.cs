namespace _08.Beer_Kegs
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            string biggest = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currVolume = Math.PI * radius * radius * height;
                if (currVolume > max)
                {
                    max = currVolume;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
