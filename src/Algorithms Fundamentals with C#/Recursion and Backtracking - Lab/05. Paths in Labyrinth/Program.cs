namespace _05._Paths_in_Labyrinth
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static List<string> path = new List<string>();
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            char[,] labyrinth = CreateLabyrinth(row, col);

            FindPaths(0, 0, string.Empty, labyrinth);
        }
        private static void FindPaths(int row, int col, string direction, char[,] labyrinth)
        {
            if (IsInBounds(row, col, labyrinth) == false)
            {
                return;
            }

            path.Add(direction);

            if (labyrinth[row, col] == 'e')
            {
                Console.WriteLine(string.Join(string.Empty, path));
            }
            else if (labyrinth[row, col] == '-')
            {
                labyrinth[row, col] = 'v';
                FindPaths(row, col + 1, "R", labyrinth);
                FindPaths(row + 1, col, "D", labyrinth);
                FindPaths(row, col - 1, "L", labyrinth);
                FindPaths(row - 1, col, "U", labyrinth);
                labyrinth[row, col] = '-';
            }
            path.RemoveAt(path.Count - 1);
        }
        private static bool IsInBounds(int row, int col, char[,] labyrinth)
        {
            return
                row >= 0 &&
                col >= 0 &&
                row < labyrinth.GetLength(0) &&
                col < labyrinth.GetLength(1);
        }

        private static char[,] CreateLabyrinth(int row, int col)
        {
            char[,] labyrinth = new char[row, col];
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    labyrinth[i, j] = line[j];
                }
            }
            return labyrinth;
        }
    }
}
