namespace _5._Square_With_Maximum_Sum
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
            int[,] matrix = new int[matrixData[0], matrixData[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int max = int.MinValue;
            string firstRow = string.Empty;
            string secondRow = string.Empty;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int one = matrix[row, col];
                    int two = matrix[row, col + 1];
                    int three = matrix[row + 1, col];
                    int four = matrix[row + 1, col + 1];
                    int sum = one + three + two + four;
                    if (sum > max)
                    {
                        max = sum;
                        firstRow = $"{one} {two}";
                        secondRow = $"{three} {four}";
                    }
                }
            }
            Console.WriteLine(firstRow);
            Console.WriteLine(secondRow);
            Console.WriteLine(max);
        }
    }
}
