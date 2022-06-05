namespace _02.Ascii_Sumator
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int sum = 0;
            int one = first;
            int two = second;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] > one && line[i] < two)
                {
                    sum += line[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
