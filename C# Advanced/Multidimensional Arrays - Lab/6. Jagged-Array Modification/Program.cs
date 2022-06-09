namespace _6._Jagged_Array_Modification
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrix[row] = new int[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    foreach (var item in matrix)
                    {
                        Console.WriteLine(string.Join(" ", item));
                    }
                    break;
                }
                string[] cmdArgs = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                if (row < 0 || row >= matrix.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (col < 0 || col >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                int value = int.Parse(cmdArgs[3]);
                if (command == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }
        }
    }
}
