using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingPlatform
{
    public class Sudoku
    {
        private const int size = 9;

        private bool SearchRow(int[,] grid, int number, int row)
        {
            for (int i = 0; i < size; i++)
            {
                if (grid[row, i] == number)
                    return true;
            }
            return false;
        }

        private bool SearchColumn(int[,] grid, int number, int col)
        {
            for (int i = 0; i < size; i++)
            {
                if (grid[i, col] == number)
                    return true;
            }
            return false;
        }
        // search the local 3x3 box
        private bool SearchBox(int[,] grid, int number, int row, int col)
        {
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;

            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    if (grid[i, j] == number)
                        return true;
                }
            }
            return false;
        }

        public bool IsValidEntry(int[,] grid, int number, int row, int col)
        {
            return !SearchRow(grid, number, row) &&
                !SearchColumn(grid, number, col) &&
                !SearchBox(grid, number, row, col);
        }
        public bool Solve(int[,] grid)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (grid[row, col] == 0)
                    {
                        for (int entry = 1; entry <= 9; entry++)
                        {
                            if (IsValidEntry(grid, entry, row, col))
                            {
                                grid[row, col] = entry;

                                if (Solve(grid))
                                {
                                    return true;
                                }
                                else
                                    grid[row, col] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public void PrintGrid(int[,] grid, TableLayoutPanel table)
        {
            int row = grid.GetLength(0);
            int column = grid.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Control control = table.GetControlFromPosition(j, i);
                    control.Text = $"{grid[i, j]}";
                }
            }
        }
    }
}
