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
    public partial class NewStudent : Form
    {
        function fn = new function();
        string query;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select roomNo from rooms where roomStatus = 'Yes'and Booked = 'No'";
            DataSet ds = fn.getData(query);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            txtIdProof.Clear();
            comboRoomNo.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermanent.Text != "" && txtCollege.Text != "" && txtIdProof.Text != "" && comboRoomNo.SelectedIndex != -1)


            { 
                
                
                
            Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmail.Text;
                String paddress = txtPermanent.Text;
                String college = txtCollege.Text;
                String idproof = txtIdProof.Text;
                Int64 roomNo = Int64.Parse(comboRoomNo.Text);

                query = "insert into newStudent(mobile,name,fname,mname,email,padddress,college,idproof,roomNo) values(" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + college + "','" + idproof + "', " + roomNo + ") update rooms set Booked = 'Yes' where roomNo = " + roomNo + "";
                fn.setData(query, "Student Registration Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All empty space. ", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
} 
