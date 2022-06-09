namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[matrixData[0], matrixData[1]];
            FillMatrix(matrix);
            string directions = Console.ReadLine();
            bool hasDied = false;
            int[] startingCoordinates = GetStartingCoordinates(matrix);
            int row = startingCoordinates[0];
            int col = startingCoordinates[1];
            foreach (char direction in directions)
            {
                matrix[row, col] = '.';
                List<int[]> bunnies = new List<int[]>();
                if (direction == 'U')
                {
                    if (row - 1 < 0)
                    {
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    if (matrix[row - 1, col] == 'B')
                    {
                        hasDied = true;
                        row -= 1;
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    row -= 1;
                    matrix[row, col] = 'P';
                    bunnies = GetBunnies(matrix);
                    hasDied = MoveBunnies(matrix, bunnies, hasDied);
                    if (hasDied)
                    {
                        break;
                    }
                }
                else if (direction == 'L')
                {
                    if (col - 1 < 0)
                    {
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    if (matrix[row, col - 1] == 'B')
                    {
                        hasDied = true;
                        col -= 1;
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    col -= 1;
                    matrix[row, col] = 'P';
                    bunnies = GetBunnies(matrix);
                    hasDied = MoveBunnies(matrix, bunnies, hasDied);
                    if (hasDied)
                    {
                        break;
                    }
                }
                else if (direction == 'R')
                {
                    if (col + 1 >= matrix.GetLength(1))
                    {
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    if (matrix[row, col + 1] == 'B')
                    {
                        hasDied = true;
                        col += 1;
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    col += 1;
                    matrix[row, col] = 'P';
                    bunnies = GetBunnies(matrix);
                    hasDied = MoveBunnies(matrix, bunnies, hasDied);
                    if (hasDied)
                    {
                        break;
                    }
                }
                else if (direction == 'D')
                {
                    if (row + 1 >= matrix.GetLength(0))
                    {
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    if (matrix[row + 1, col] == 'B')
                    {
                        hasDied = true;
                        row += 1;
                        bunnies = GetBunnies(matrix);
                        hasDied = MoveBunnies(matrix, bunnies, hasDied);
                        break;
                    }
                    row += 1;
                    matrix[row, col] = 'P';
                    bunnies = GetBunnies(matrix);
                    hasDied = MoveBunnies(matrix, bunnies, hasDied);
                    if (hasDied)
                    {
                        break;
                    }
                }
            }
            if (hasDied)
            {
                PrintMatrix(matrix);
                Console.WriteLine($"dead: {row} {col}");
            }
            else
            {
                PrintMatrix(matrix);
                Console.WriteLine($"won: {row} {col}");
            }
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        private static bool MoveBunnies(char[,] matrix, List<int[]> bunnies, bool hasDied)
        {
            foreach (int[] bunnie in bunnies)
            {
                int row = bunnie[0];
                int col = bunnie[1];
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col] == 'P')
                    {
                        matrix[row - 1, col] = 'B';
                        hasDied = true;
                    }
                    if (matrix[row - 1, col] == '.')
                    {
                        matrix[row - 1, col] = 'B';
                    }
                }
                if (col - 1 >= 0)
                {
                    if (matrix[row, col - 1] == 'P')
                    {
                        matrix[row, col - 1] = 'B';
                        hasDied = true;
                    }
                    if (matrix[row, col - 1] == '.')
                    {
                        matrix[row, col - 1] = 'B';
                    }
                }
                if (col + 1 < matrix.GetLength(1))
                {
                    if (matrix[row, col + 1] == 'P')
                    {
                        matrix[row, col + 1] = 'B';
                        hasDied = true;
                    }
                    if (matrix[row, col + 1] == '.')
                    {
                        matrix[row, col + 1] = 'B';
                    }
                }
                if (row + 1 < matrix.GetLength(0))
                {
                    if (matrix[row + 1, col] == 'P')
                    {
                        matrix[row + 1, col] = 'B';
                        hasDied = true;
                    }
                    if (matrix[row + 1, col] == '.')
                    {
                        matrix[row + 1, col] = 'B';
                    }
                }
            }
            return hasDied;
        }

        private static List<int[]> GetBunnies(char[,] matrix)
        {
            List<int[]> bunnies = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        int[] currBunnie = new int[2] { row, col };
                        bunnies.Add(currBunnie);
                    }
                }
            }
            return bunnies;
        }

        private static int[] GetStartingCoordinates(char[,] matrix)
        {
            int[] personCoordinates = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        personCoordinates[0] = row;
                        personCoordinates[1] = col;
                    }
                }
            }
            return personCoordinates;
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
