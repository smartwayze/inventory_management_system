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
    public partial class frmproducts : Form
    {
        public frmproducts()
        {
            InitializeComponent();
        }
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        categoriesDAL cdal = new categoriesDAL();
        private void frmproducts_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            cmbcategory.DataSource = categoriesDT;
            cmbcategory.DisplayMember = "title";
            cmbcategory.ValueMember = "title";
            DataTable dt = pdal.Select();
            dgvproducts.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            p.name = txtname.Text;
            p.category = cmbcategory.Text;
            p.description = txtdescription.Text;
            p.rate =decimal.Parse(txtrate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromusername(loggeduser);
            p.added_by = usr.id;

            bool success = pdal.INSERT(p);
            if (success == true)
            {
                MessageBox.Show("User Added Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Add new user");
            }
            DataTable dt = pdal.Select();
            dgvproducts.DataSource = dt;
        }
        private void clear()
        {
           txtproductid.Text = "";
            txtname.Text = "";
            cmbcategory.Text = "";
            txtdescription.Text = "";
            txtrate.Text = "";

        }

        private void dgvproducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtproductid.Text = dgvproducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtname.Text = dgvproducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbcategory.Text = dgvproducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtdescription.Text = dgvproducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtrate.Text = dgvproducts.Rows[rowIndex].Cells[4].Value.ToString();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtproductid.Text);
            p.name = txtname.Text;
            p.category = cmbcategory.Text;
            p.description = txtdescription.Text;
            p.rate = decimal.Parse(txtrate.Text);
            p.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromusername(loggeduser);
            p.added_by = usr.id;

            bool success = pdal.UPDATE(p);
            if (success == true)
            {
                MessageBox.Show("User Updated Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed Updated user");
            }
            DataTable dt = pdal.Select();
            dgvproducts.DataSource = dt;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtproductid.Text);
            bool success = pdal.DELETE(p);
            if (success == true)
            {
                MessageBox.Show("User Deleted Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete user");
            }
            DataTable dt = pdal.Select();
            dgvproducts.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;
            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgvproducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Search(keywords);
                dgvproducts.DataSource = dt;
            }
        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
