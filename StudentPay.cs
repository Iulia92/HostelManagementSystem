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
    public partial class StudentPay : Form
    {
        function fn = new function();
        String query;

        public StudentPay()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                query = " select name,email,roomNo from newStudent where mobile =" + txtMobile.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(Int64.Parse(txtMobile.Text));
                }
            }

            else
            {
                MessageBox.Show("No Record exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void setDataGrid(Int64 mobile)
        {
            query = "select * from fees where mobileNo = " + mobile + "";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtAmount.Text != "")
            {
                query = "select * from fees where mobileNo = " + Int64.Parse(txtMobile.Text) + " and fmonth = '" + dateTimePicker.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = dateTimePicker.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);
                    query = "insert intro fees values(" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Fees Paid.");
                    clearAll();
                }
                else
                {
                    MessageBox.Show("No dues of" + dateTimePicker.Text + "Left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
            public void clearAll()
            {
                txtMobile.Clear();
                txtName.Clear();
                txtAmount.Clear();
                txtRoomNo.Clear();
                txtEmail.Clear();
                guna2DataGridView1.DataSource = 0;
            }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentPay_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM yyyy";

        }
    }
}
