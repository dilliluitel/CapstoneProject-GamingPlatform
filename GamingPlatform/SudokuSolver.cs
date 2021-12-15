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

        int[,] board = {
            {7,0,2,0,5,0,6,0,0},
            {0,0,0,0,0,3,0,0,0},
            {1,0,0,0,0,9,5,0,0},
            {8,0,0,0,0,0,0,9,0},
            {0,4,3,0,0,0,7,5,0},
            {0,9,0,0,0,0,0,0,8},
            {0,0,9,7,0,0,0,0,5},
            {0,0,0,2,0,0,0,0,0},
            {0,0,7,0,4,0,2,0,3}
           };

        public SudokuSolver()
        {
            InitializeComponent();
          //  AssignLabelToGrid();
        }

        private void AssignLabelToGrid()
        {
           // int row = Board.RowCount;
            //int column = Board.ColumnCount;

            //TextBox box = null;
/*            for (int i = 0; i < Board.Controls.Count; i++)
            {
                if (Board.Controls[i] is TextBox)
                {
                    box = (TextBox)Board.Controls[i];
                    box.Text = $"{i}";
                }
                else
                    continue;
            }*/
            /*for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Control C = Board.GetControlFromPosition(column, row);
                    if (box != null)
                        box.Text = "A";
                    else
                        continue;
                }
            }*/

        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            int row = Board.RowCount;
            int column = Board.ColumnCount;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Control C = Board.GetControlFromPosition(i, j);
                    if(board[i, j] == 0)
                        C.Text = "";
                    else
                        C.Text = $"{board[i, j]}";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sudoku.Solve(board);

            int row = Board.RowCount;
            int column = Board.ColumnCount;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Control C = Board.GetControlFromPosition(i, j);
                    if (board[i, j] == 0)
                        C.Text = "";
                    else
                        C.Text = $"{board[i, j]}";
                }
            }
        }
    }
}