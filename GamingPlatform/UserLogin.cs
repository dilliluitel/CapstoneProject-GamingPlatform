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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToLower();
            string password = textBox2.Text;

            if (username == "admin" && password == "123")
            {
                //MessageBox.Show("Login Success");

                MDIParent1 parent = new MDIParent1();
                parent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }
    }
}
