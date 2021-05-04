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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        string query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where emobile = " + txtMobile.Text + "";

            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtUniqueID.Text = ds.Tables[0].Rows[0][7].ToString();
                txtDesignation.Text = ds.Tables[0].Rows[0][8].ToString();
                txtWorkimg.Text = ds.Tables[0].Rows[0][9].ToString();

            }
            else
            {
                //clearAll();
                MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String fname = txtFather.Text;
            String mname = txtMother.Text;
            String email = txtEmail.Text;
            String paddress = txtPermanent.Text;
            String id = txtUniqueID.Text;
            String designation = txtDesignation.Text;
            String working = txtWorkimg.Text;

            query = "update newEmployee set ename='" + name + "',efname='" + fname + "',emname='" + mname + "',eemail='" + email + "',epadddress='" + paddress + "',eidproof='" + id + "',edesignation = '" + designation + "' ,working = '" + working + "'where emobile = " + mobile + "";
            fn.setData(query, "Data updated Succesful.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newEmployee where emobile = " + txtMobile.Text + "";
                fn.setData(query, "Employee Record Deleated.");
                clearAll();
            }

        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermanent.Clear();
            txtUniqueID.Clear();
            txtDesignation.Clear();
            txtWorkimg.SelectedIndex = -1;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}