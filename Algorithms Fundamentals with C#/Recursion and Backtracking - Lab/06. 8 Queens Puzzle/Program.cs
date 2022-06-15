namespace _06._8_Queens_Puzzle
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static HashSet<int> attackedRows = new HashSet<int>();
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        private static HashSet<int> attackedRightDiagonals = new HashSet<int>();
        static void Main(string[] args)
        {
            bool[,] chessboard = new bool[8, 8];

            PutQueens(chessboard, 0);
        }

        private static void PutQueens(bool[,] chessboard, int row)
        {
            if (row >= chessboard.GetLength(0))
            {
                PrintChessboard(chessboard);
                return;
            }
            for (int col = 0; col < chessboard.GetLength(1); col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    attackedRows.Add(row);
                    attackedCols.Add(col);
                    attackedLeftDiagonals.Add(row - col);
                    attackedRightDiagonals.Add(row + col);
                    chessboard[row, col] = true;

                    PutQueens(chessboard, row + 1);

                    attackedRows.Remove(row);
                    attackedCols.Remove(col);
                    attackedLeftDiagonals.Remove(row - col);
                    attackedRightDiagonals.Remove(row + col);
                    chessboard[row, col] = false;
                }
            }
        }

        private static void PrintChessboard(bool[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    if (chessboard[row, col])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return
                attackedRows.Contains(row) == false &&
                attackedCols.Contains(col) == false &&
                attackedLeftDiagonals.Contains(row - col) == false &&
                attackedRightDiagonals.Contains(row + col) == false;
        }
    }
}