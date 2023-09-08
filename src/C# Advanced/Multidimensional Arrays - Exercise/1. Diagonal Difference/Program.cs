namespace _01._Diagonal_Difference
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                primaryDiagonal += matrix[col, col];
            }
            int cols = matrix.GetLength(1) - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secondaryDiagonal += matrix[row, cols];
                cols--;
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
