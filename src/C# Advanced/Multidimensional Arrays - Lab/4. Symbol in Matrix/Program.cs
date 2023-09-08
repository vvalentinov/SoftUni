namespace _4._Symbol_in_Matrix
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool foundSymbol = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        foundSymbol = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
                if (foundSymbol)
                {
                    break;
                }
            }
            if (!foundSymbol)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
