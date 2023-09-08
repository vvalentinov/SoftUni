namespace _06._Jagged_Array_Manipulator
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrix[row] = new double[arr.Length];
                for (int col = 0; col < arr.Length; col++)
                {
                    matrix[row][col] = arr[col];
                }
            }
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                int lenght = matrix[row].Length;
                int nextRowLenght = matrix[row + 1].Length;
                if (lenght == nextRowLenght)
                {
                    MultiplyElements(matrix, row, row + 1);
                }
                else
                {
                    DivideElements(matrix, row, row + 1);
                }
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    PrintMatrix(matrix);
                    break;
                }
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                int row = int.Parse(parts[1]);
                int column = int.Parse(parts[2]);
                double value = double.Parse(parts[3]);
                if (row < 0 || row >= matrix.Length)
                {
                    continue;
                }
                if (column < 0 || column >= matrix[row].Length)
                {
                    continue;
                }
                if (command == "Add")
                {
                    matrix[row][column] += value;
                }
                else
                {
                    matrix[row][column] -= value;
                }
            }
        }
        private static void PrintMatrix(double[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        private static void DivideElements(double[][] matrix, int row, int v)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] /= 2;
            }
            for (int col = 0; col < matrix[v].Length; col++)
            {
                matrix[v][col] /= 2;
            }
        }

        private static void MultiplyElements(double[][] matrix, int row, int v)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] *= 2;
            }
            for (int col = 0; col < matrix[v].Length; col++)
            {
                matrix[v][col] *= 2;
            }
        }
    }
}
