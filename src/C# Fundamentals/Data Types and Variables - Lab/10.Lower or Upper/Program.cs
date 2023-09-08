namespace _10.Lower_or_Upper
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if (char.IsUpper(symbol))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
