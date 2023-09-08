namespace _09._Miner
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            FillMatrix(matrix, size);
            int[] startCoordinates = GetCoordinates(matrix, size);
            int row = startCoordinates[0];
            int col = startCoordinates[1];
            int coals = 0;
            bool gameOver = false;
            foreach (string command in commands)
            {
                switch (command)
                {
                    case "up":
                        if (row - 1 < 0)
                        {
                            continue;
                        }
                        row -= 1;
                        if (matrix[row, col] == 'c')
                        {
                            coals++;
                            matrix[row, col] = '*';
                        }
                        if (matrix[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            gameOver = true;
                            break;
                        }
                        break;
                    case "right":
                        if (col + 1 >= size)
                        {
                            continue;
                        }
                        col += 1;
                        if (matrix[row, col] == 'c')
                        {
                            coals++;
                            matrix[row, col] = '*';
                        }
                        if (matrix[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            gameOver = true;
                            break;
                        }
                        break;
                    case "left":
                        if (col - 1 < 0)
                        {
                            continue;
                        }
                        col -= 1;
                        if (matrix[row, col] == 'c')
                        {
                            coals++;
                            matrix[row, col] = '*';
                        }
                        if (matrix[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            gameOver = true;
                            break;
                        }
                        break;
                    case "down":
                        if (row + 1 >= size)
                        {
                            continue;
                        }
                        row += 1;
                        if (matrix[row, col] == 'c')
                        {
                            coals++;
                            matrix[row, col] = '*';
                        }
                        if (matrix[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            gameOver = true;
                            break;
                        }
                        break;
                }
            }
            if (!gameOver)
            {
                int coalsLeft = CheckCoals(matrix, size);
                if (coalsLeft == 0)
                {
                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                }
                else
                {
                    Console.WriteLine($"{coalsLeft} coals left. ({row}, {col})");
                }
            }
        }
        private static int CheckCoals(char[,] matrix, int size)
        {
            int left = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        left++;
                    }
                }
            }
            return left;
        }

        private static int[] GetCoordinates(char[,] matrix, int size)
        {
            int[] arr = new int[2];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        arr[0] = row;
                        arr[1] = col;
                    }
                }
            }
            return arr;
        }

        private static void FillMatrix(char[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                char[] arr = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
