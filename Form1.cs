using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if( txtUsername.Text == "Julya" && txtPassword.Text == "pass")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();

            }
            else
            {
                txtPassword.Clear();
            }
        }
    }
}
