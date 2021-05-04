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
    public partial class AddBewRoom : Form
    {
        function fn = new function();
        String query;
        public AddBewRoom()
        {
            InitializeComponent();
        }

        private void AddBewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            labelRoom.Visible = false;
            labelRoomExist.Visible = false;


            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

    
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo= " + txtRoomNo1.Text + "";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count ==0)
            {
                String status;
                if(checkBox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelRoomExist.Visible = false;
                query = "insert into rooms(roomNo,roomStatus) values(" + txtRoomNo1.Text + " , '" + status + "')";
                fn.setData(query, "Room Added.");
                AddBewRoom_Load(this, null);
            }
            {
                labelRoomExist.Text = "Room All Ready Exist.";
                labelRoomExist.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo= " + txtRoomNo2.Text + "";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count ==0)

            {
                labelRoom.Text = "No Room Exist.";
                labelRoom.Visible = true;
                checkBox2.Checked = false;
                     
                
            }
            else
            {
                labelRoom.Text = "Room Found";
                labelRoom.Visible = true;
                   if(ds.Tables[0].Rows[0][1].ToString()=="Yes" )
                {
                    checkBox2.Checked = true;

                }

                else
                {
                    checkBox2.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status;
            if(checkBox2.Checked)
            {
                status = "Yes";

            }

            else
            {
                status = "No";
            }
            query = "update rooms set roomStatus='" + status + "' where roomNo = " + txtRoomNo2.Text + "";
            fn.setData(query, "Details Updated.");
            AddBewRoom_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (labelRoom.Text == "Room Found")
            {
                query = "delete from rooms where roomNo= " + txtRoomNo2.Text + "";
                fn.setData(query, "Room Details Deleated");
                AddBewRoom_Load(this, null);

            }
            else
            {
               MessageBox.Show("Trying to delete witch doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}
