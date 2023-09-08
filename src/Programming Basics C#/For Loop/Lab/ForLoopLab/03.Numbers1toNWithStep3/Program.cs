namespace _03.Numbers1toNWithStep3
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
