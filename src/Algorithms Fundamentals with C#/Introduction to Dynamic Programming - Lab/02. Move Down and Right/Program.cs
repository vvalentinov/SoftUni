namespace _02._Move_Down_and_Right
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                int[] rowElements = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToArray();

                for (int c = 0; c < rowElements.Length; c++)
                {
                    matrix[r, c] = rowElements[c];
                }
            }

            int[,] dp = new int[rows, cols];
            dp[0, 0] = matrix[0, 0];

            for (int c = 1; c < cols; c++)
            {
                dp[0, c] = dp[0, c - 1] + matrix[0, c];
            }

            for (int r = 1; r < rows; r++)
            {
                dp[r, 0] = dp[r - 1, 0] + matrix[r, 0];
            }

            for (int r = 1; r < rows; r++)
            {
                for (int c = 1; c < cols; c++)
                {
                    int upper = dp[r - 1, c];
                    int left = dp[r, c - 1];

                    dp[r, c] = Math.Max(upper, left) + matrix[r, c];
                }
            }

            Stack<string> path = new Stack<string>();

            int row = rows - 1;
            int col = cols - 1;

            while (row > 0 && col > 0)
            {
                path.Push($"[{row}, {col}]");

                int upper = dp[row - 1, col];
                int left = dp[row, col - 1];

                if (upper > left)
                {
                    row--;
                }
                else
                {
                    col--;
                }
            }

            while (row > 0)
            {
                path.Push($"[{row}, {col}]");
                row--;
            }

            while (col > 0)
            {
                path.Push($"[{row}, {col}]");
                col--;
            }

            path.Push($"[{row}, {col}]");

            Console.WriteLine(string.Join(' ', path));
        }
    }
}