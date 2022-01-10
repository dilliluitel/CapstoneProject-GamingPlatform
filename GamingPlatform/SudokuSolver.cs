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

        int[,] grid = null; 
        int[,] puzzleState = null;

        public SudokuSolver()
        {
            grid = (int[,])puzzle.GetPuzzle(0).Clone();
            puzzleState = (int[,])puzzle.GetPuzzle(0).Clone();

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
                    C.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

                    if (grid[i, j] == 0)
                    {
                        C.Text = "";
                    }
                    else
                    {
                        C.Text = $"{grid[i, j]}";
                        C.ForeColor = Color.Red;
                    }
                }
            }
        }

        //TextChanged event handler
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = sender as TextBox;
            TableLayoutPanelCellPosition cell = Board.GetPositionFromControl(tBox);

            if (string.IsNullOrEmpty(tBox.Text))
            {
                grid[cell.Row, cell.Column] = 0;
                return;
            }
            if (int.TryParse(tBox.Text, out int result))
            {
               if (result < 1 || result > 9)
                    MessageBox.Show("Invalid Entry");

                grid[cell.Row, cell.Column] = result;
                tBox.ForeColor = Color.Green;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
                    grid[i, j] = puzzleState[i,j];            

                    Control C = Board.GetControlFromPosition(j, i);
                    tBox = (TextBox)C;
                    tBox.Clear();
                }
            }

            levelComboBox_SelectedIndexChanged(sender, e);
        }

        private void levelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int key = random.Next(3);

            int puzzleLevel = 0;
            switch (levelComboBox.SelectedItem)
            {
                case "Easy":
                puzzleLevel = (int) PuzzleLevel.Easy + key; 
                    break;

                case "Medium":
                puzzleLevel = (int) PuzzleLevel.Medium + key;
                    break;

                case "Hard":
                puzzleLevel = (int) PuzzleLevel.Hard + key;
                    break;

            }

            grid = (int[,])puzzle.GetPuzzle(puzzleLevel).Clone();
            puzzleState = (int[,])puzzle.GetPuzzle(puzzleLevel).Clone();

            for (int i = 0; i < Board.Controls.Count; i++)
                {
                    Control C = Board.Controls[i];
                    C.TextChanged += new System.EventHandler(textBox_TextChanged);
                } 
        }
    }
}