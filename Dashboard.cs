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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddBewRoom anr = new AddBewRoom();
            anr.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
          StudentPay sp = new StudentPay();
            sp.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)
        {
            AllStudentLiving asl = new AllStudentLiving();
            asl.Show();
        }

        private void btnLeavedStudent_Click(object sender, EventArgs e)
        {
            LeavedStudents ls = new LeavedStudents();
            ls.Show();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployeee ne = new NewEmployeee();
            ne.Show();
        }

        private void btnUpdateDeleteEmployee_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee ude = new UpdateDeleteEmployee();
            ude.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            EmployeePayment ep = new EmployeePayment();
            ep.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            AllEmployeeWorking aep = new AllEmployeeWorking();
            aep.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            LeavedEmployee ls = new LeavedEmployee();
            ls.Show();
        }
    }
}
