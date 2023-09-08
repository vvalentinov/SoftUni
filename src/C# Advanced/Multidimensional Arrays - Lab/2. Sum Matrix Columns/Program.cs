namespace _2._Sum_Matrix_Columns
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixData[0];
            int cols = matrixData[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
