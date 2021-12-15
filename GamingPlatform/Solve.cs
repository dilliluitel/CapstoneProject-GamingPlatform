using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingPlatform
{
    public class Sudoku
    {
        private int size = 9;

        private bool SearchRow(int[,] board, int number, int row)
        {
            // int size = board.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                if (board[row, i] == number)
                    return true;
            }
            return false;
        }
        private bool SearchColumn(int[,] board, int number, int col)
        {
            //int size = board.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                if (board[i, col] == number)
                    return true;
            }
            return false;
        }
        private bool SearchBox(int[,] board, int number, int row, int col)
        {
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;

            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    if (board[i, j] == number)
                        return true;
                }
            }
            return false;
        }
        private bool IsValidEntry(int[,] board, int number, int row, int col)
        {
            return !SearchRow(board, number, row) &&
                !SearchColumn(board, number, col) &&
                !SearchBox(board, number, row, col);
        }
        public bool Solve(int[,] board)
        {
            // int size = board.GetLength(0);

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (board[row, col] == 0)
                    {
                        for (int entry = 1; entry <= size; entry++)
                        {
                            if (IsValidEntry(board, entry, row, col))
                            {
                                board[row, col] = entry;

                                if (Solve(board))
                                {
                                    return true;
                                }
                                else
                                    board[row, col] = 0;
                            }
                        }
                        return false;
                    }
                }

            }
            return true;
        }
        public void PrintBoard(int[,] board)
        {
            //int size = board.GetLength(0);
            for (int row = 0; row < size; row++)
            {
                if (row % 3 == 0 && row != 0)
                    Console.WriteLine("-----------");
                for (int col = 0; col < size; col++)
                {
                    if (col % 3 == 0 && col != 0)
                        Console.Write("|");
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();

            }
        }
    }
}
