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
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        //this code is work in progress and thus incomplete at this point
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 3;

            int gridSize = 3;
            int row = gridSize;
            int col = gridSize;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                { 
                    Button btn = new Button();
                    btn.Text = col.ToString();
                    btn.Dock = DockStyle.Fill;
                    
                    tableLayoutPanel1.Controls.Add(btn, col, row);

                }
            }
        }

    }
}
