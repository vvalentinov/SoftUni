namespace _08._Bombs
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if (size > 0)
            {
                int[,] matrix = new int[size, size];
                for (int row = 0; row < size; row++)
                {
                    int[] rowData = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    for (int col = 0; col < size; col++)
                    {
                        matrix[row, col] = rowData[col];
                    }
                }
                string[] bombsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in bombsInfo)
                {
                    int[] arr = item.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    int row = arr[0];
                    int col = arr[1];
                    int value = matrix[row, col];
                    if (value <= 0)
                    {
                        continue;
                    }
                    if (col - 1 >= 0 && matrix[row, col - 1] > 0)
                    {
                        matrix[row, col - 1] -= value;
                    }
                    if (row - 1 >= 0 && col - 1 >= 0 && matrix[row - 1, col - 1] > 0)
                    {
                        matrix[row - 1, col - 1] -= value;
                    }
                    if (row - 1 >= 0 && matrix[row - 1, col] > 0)
                    {
                        matrix[row - 1, col] -= value;
                    }
                    if (row - 1 >= 0 && col + 1 < size && matrix[row - 1, col + 1] > 0)
                    {
                        matrix[row - 1, col + 1] -= value;
                    }
                    if (col + 1 < size && matrix[row, col + 1] > 0)
                    {
                        matrix[row, col + 1] -= value;
                    }
                    if (row + 1 < size && col + 1 < size && matrix[row + 1, col + 1] > 0)
                    {
                        matrix[row + 1, col + 1] -= value;
                    }
                    if (row + 1 < size && matrix[row + 1, col] > 0)
                    {
                        matrix[row + 1, col] -= value;
                    }
                    if (row + 1 < size && col - 1 >= 0 && matrix[row + 1, col - 1] > 0)
                    {
                        matrix[row + 1, col - 1] -= value;
                    }
                    matrix[row, col] = 0;
                }
                int activeCells = 0;
                int sum = 0;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            activeCells++;
                            sum += matrix[row, col];
                        }
                    }
                }
                Console.WriteLine($"Alive cells: {activeCells}");
                Console.WriteLine($"Sum: {sum}");
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write($"{matrix[row, col]}" + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
