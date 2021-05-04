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
    public partial class AllStudentLiving : Form
    {
        function fn = new function();
        String query;
        public AllStudentLiving()
        {
            InitializeComponent();
        }

        private void AllStudentLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select * from newStudent where living = 'Yes'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
