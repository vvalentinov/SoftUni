namespace _05.Add_and_Subtract
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Subtract(first, second, third);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b, int c)
        {
            int output = Sum(a, b) - c;
            Console.WriteLine(output);
            return output;
        }
    }
}
