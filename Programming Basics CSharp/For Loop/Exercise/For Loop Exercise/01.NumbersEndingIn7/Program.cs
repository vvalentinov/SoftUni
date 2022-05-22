namespace _01.NumbersEndingIn7
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 997; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
