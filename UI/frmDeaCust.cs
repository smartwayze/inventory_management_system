using SaadStationers1.BLL;
using SaadStationers1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaadStationers1.UI
{
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }
        deacustBLL dc = new deacustBLL();
        deacustDAL dcdal = new deacustDAL();
        userDAL udal = new userDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dc.type = combtype.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromusername(loggeduser);
            dc.added_by = usr.id;

            bool success = dcdal.INSERT(dc);
            if (success == true)
            {
                MessageBox.Show("User Added Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Add new user");
            }
            DataTable dt = dcdal.Select();
            dgvdeacust.DataSource = dt;
        }
        private void clear()
        {
            txtdeacustid.Text = "";
            combtype.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";

        }
        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            
            DataTable dt = dcdal.Select();
            dgvdeacust.DataSource = dt;
        }
        private void dgvdeacust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtdeacustid.Text = dgvdeacust.Rows[rowIndex].Cells[0].Value.ToString();
            combtype.Text = dgvdeacust.Rows[rowIndex].Cells[1].Value.ToString();
            txtname.Text = dgvdeacust.Rows[rowIndex].Cells[2].Value.ToString();
            txtemail.Text = dgvdeacust.Rows[rowIndex].Cells[3].Value.ToString();
            txtcontact.Text = dgvdeacust.Rows[rowIndex].Cells[4].Value.ToString();
            txtaddress.Text = dgvdeacust.Rows[rowIndex].Cells[5].Value.ToString();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            dc.id = Convert.ToInt32(txtdeacustid.Text);
            dc.type = combtype.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromusername(loggeduser);
            dc.added_by = usr.id;

            bool success = dcdal.UPDATE(dc);
            if (success == true)
            {
                MessageBox.Show("User Updated Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed Updated user");
            }
            DataTable dt = dcdal.Select();
            dgvdeacust.DataSource = dt;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            dc.id = Convert.ToInt32(txtdeacustid.Text);
            bool success = dcdal.DELETE(dc);
            if (success == true)
            {
                MessageBox.Show("User Deleted Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete user");
            }
            DataTable dt = dcdal.Select();
            dgvdeacust.DataSource = dt;
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;
            if (keywords != null)
            {
                DataTable dt = dcdal.Search(keywords);
                dgvdeacust.DataSource = dt;
            }
            else
            {
                DataTable dt = dcdal.Search(keywords);
                dgvdeacust.DataSource = dt;
            }
        }

       
    }
}
