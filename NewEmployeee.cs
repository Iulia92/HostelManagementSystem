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
    public partial class NewEmployeee : Form
    {
        function fn = new function();
        String query;
        public NewEmployeee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewEmployeee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // if(txtName.Text !=0 "" &&)
                    if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermanent.Text != "" && txtUniqueID.Text != "" & comboDesignatio.SelectedIndex != -1)

            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmail.Text;
                String paddress = txtPermanent.Text;
                String id = txtUniqueID.Text;
               String designation = comboDesignatio.Text;

                query = "insert into newEmployee(emobile,ename,efname,emname,eemail,eidproof,epadddress,edesignation) values(" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + id+ "', '" + designation + "') ";
                fn.setData(query, "Employee Registration Successful.");
                //clearAll();
            }
                    else
            {
                MessageBox.Show("Fill all Required Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtUniqueID.Clear();
               
                comboRoomNo.SelectedIndex = -1;
            }
        
    }
}
