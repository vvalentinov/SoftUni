namespace _07._Knight_Game
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int countReplaced = 0;
            int rowKiller = 0;
            int colKiller = 0;
            while (true)
            {
                int maxAttacks = 0;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        char curr = matrix[row, col];
                        int countAttacks = 0;
                        if (curr == 'K')
                        {
                            countAttacks = GetAttacks(matrix, row, col, countAttacks);
                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                rowKiller = row;
                                colKiller = col;
                            }
                        }
                    }
                }
                if (maxAttacks > 0)
                {
                    matrix[rowKiller, colKiller] = '0';
                    countReplaced++;
                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }
        }
        private static int GetAttacks(char[,] matrix, int row, int col, int countAttacks)
        {
            if (col + 2 < matrix.GetLength(1) && row + 1 < matrix.GetLength(0) && matrix[row + 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (col + 2 < matrix.GetLength(1)
                && row - 1 >= 0
                && matrix[row - 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (col - 2 >= 0 && row - 1 >= 0 && matrix[row - 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (col - 2 >= 0 && row + 1 < matrix.GetLength(0) && matrix[row + 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (col + 1 < matrix.GetLength(1) && row - 2 >= 0 && matrix[row - 2, col + 1] == 'K')
            {
                countAttacks++;
            }
            if (col - 1 >= 0 && row - 2 >= 0 && matrix[row - 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (col + 1 < matrix.GetLength(1) && row + 2 < matrix.GetLength(0) && matrix[row + 2, col + 1] == 'K')
            {
                countAttacks++;
            }
            if (col - 1 >= 0 && row + 2 < matrix.GetLength(0) && matrix[row + 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            return countAttacks;
        }
    }
}
