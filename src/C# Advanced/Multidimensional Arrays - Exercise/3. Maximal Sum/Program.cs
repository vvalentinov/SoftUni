namespace _03._Maximal_Sum
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixData[0];
            int cols = matrixData[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int firstRow = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int secondRow = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int thirdRow = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    int sum = firstRow + secondRow + thirdRow;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");
        }
    }
}
