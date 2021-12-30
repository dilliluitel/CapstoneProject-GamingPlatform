using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingPlatform
{
    public partial class SudokuSolver : Form
    {
        Sudoku sudoku = new Sudoku();
        Puzzle puzzle = new Puzzle();

        const int size = 9;
        int[,] grid = new int[size, size];

        public SudokuSolver()
        {
           grid = puzzle.GetPuzzle(0);
           InitializeComponent();
        }

        //Table Layout for sudoku board
        private void Board_Paint(object sender, PaintEventArgs e)
        {
            int row = Board.RowCount;
            int column = Board.ColumnCount;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Control C = Board.GetControlFromPosition(j, i);
                    C.TextChanged += new System.EventHandler(textBox_TextChanged);
                    
                    if (grid[i, j] == 0)
                        C.Text = "";
                    else
                        C.Text = $"{grid[i, j]}";
                }
            }
        }

        //TextChanged event handler
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = sender as TextBox;
            TableLayoutPanelCellPosition cell = Board.GetPositionFromControl(tBox);
            if (string.IsNullOrEmpty(tBox.Text))
                return;

            if (int.TryParse(tBox.Text, out int result))
            {
                grid[cell.Row, cell.Column] = result;
                tBox.ForeColor = Color.Green;
            }
        }

        //Solve button
        private void Solve_Click(object sender, EventArgs e)
        {
            if (sudoku.Solve(grid))
            {
                sudoku.PrintGrid(grid, Board);
                display.Text = "Solved!";
            }
            else
                display.Text = "Unsolvable grid.";
        }

        //submit button
        private void Submit_Click(object sender, EventArgs e)
        {
            int row = Board.RowCount;
            int column = Board.ColumnCount;
            int temp=0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    grid[i, j] = 0;             //clears the initial grid

                    Control C = Board.GetControlFromPosition(j, i);

                    if (string.IsNullOrEmpty(C.Text))
                    {
                        display.Text = "Board is not fully populated!";
                        return;
                    }
                    else if (int.TryParse(C.Text, out int result))
                    {
                            temp = result;
                    }

                    if (sudoku.IsValidEntry(grid, temp, i, j))
                        grid[i, j] = temp;      //adds the number back to grid.
                    else
                    {
                        display.Text = "Incorrect Solution.";
                        return;
                    }
                }
            }
            sudoku.PrintGrid(grid, Board);
            display.Text = "You solved it successfully!";
        }

        //Clear button
        private void Clear_Click(object sender, EventArgs e)
        {
            int row = Board.RowCount;
            int column = Board.ColumnCount;
            TextBox tBox;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    grid[i, j] = 0;             //clears the initial grid

                    Control C = Board.GetControlFromPosition(j, i);
                    tBox = (TextBox)C;
                    tBox.Clear();
                }
            }

            levelComboBox_SelectedIndexChanged(sender, e);

        }

        private void levelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (levelComboBox.SelectedItem)
                {
                    case "Easy":
                        grid = puzzle.GetPuzzle(0);
                        break;

                    case "Medium":
                        grid = puzzle.GetPuzzle(1);
                        break;

                    case "Hard":
                        grid = puzzle.GetPuzzle(2);
                        break;

                }
                for (int i = 0; i < Board.Controls.Count; i++)
                {
                    Control C = Board.Controls[i];
                    C.TextChanged += new System.EventHandler(textBox_TextChanged);
                } 
        }
    }
}