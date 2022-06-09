namespace _04._Matrix_Shuffling
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
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if ((parts[0] != "swap") || (parts.Length != 5))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int firstPairRow = int.Parse(parts[1]);
                int firstPairCol = int.Parse(parts[2]);
                int secondPairRow = int.Parse(parts[3]);
                int secondPairCol = int.Parse(parts[4]);
                if (firstPairRow < 0 ||
                    firstPairRow >= matrix.GetLength(0) ||
                    firstPairCol < 0 ||
                    firstPairCol >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (secondPairRow < 0 ||
                    secondPairRow >= matrix.GetLength(0) ||
                    secondPairCol < 0 ||
                    secondPairCol >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string item = matrix[firstPairRow, firstPairCol];
                matrix[firstPairRow, firstPairCol] = matrix[secondPairRow, secondPairCol];
                matrix[secondPairRow, secondPairCol] = item;
                PrintMatrix(matrix);
            }
        }
        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
