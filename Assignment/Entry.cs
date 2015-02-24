using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPassword.Visible = true;
            lblUserName.Visible = true;
            txtPassword.Visible = true;
            txtUserName.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainDisplay tDGV = new MainDisplay();
            tDGV.Show();
            this.Hide();
        }
    }
}
