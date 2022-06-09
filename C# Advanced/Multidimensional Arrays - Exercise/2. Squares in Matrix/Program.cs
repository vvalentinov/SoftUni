namespace _02._Squares_in_Matrix
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixData[0];
            int cols = matrixData[1];
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
            int number = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char first = matrix[row, col];
                    char second = matrix[row, col + 1];
                    char third = matrix[row + 1, col];
                    char fourth = matrix[row + 1, col + 1];
                    if ((first != second) || (third != fourth) || (first != third))
                    {
                        continue;
                    }
                    number++;
                }
            }
            Console.WriteLine(number);
        }
    }
}
