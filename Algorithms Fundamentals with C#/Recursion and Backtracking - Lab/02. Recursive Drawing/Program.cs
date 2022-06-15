﻿namespace _02._Recursive_Drawing
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawFigure(n);
        }
        private static void DrawFigure(int n)
        {
            if (n <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));
            DrawFigure(n - 1);
            Console.WriteLine(new string('#', n));
        }
    }
}
