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
    public partial class frmcategories : Form
    {
        public frmcategories()
        {
            InitializeComponent();
        }
        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            c.title = txttitle.Text;
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromusername(loggeduser);
            c.added_by = usr.id;

            bool success = dal.INSERT(c);
            if (success == true)
            {
                MessageBox.Show("User Added Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Add new user");
            }
            DataTable dt = dal.Select();
            dgvcategories.DataSource = dt;
        }

        private void frmcategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvcategories.DataSource = dt;
        }
        private void clear()
        {
            txtcategoryid.Text = "";
            txttitle.Text = "";
            txtdescription.Text = "";
           
        }

        private void dgvcategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtcategoryid.Text = dgvcategories.Rows[rowIndex].Cells[0].Value.ToString();
            txttitle.Text = dgvcategories.Rows[rowIndex].Cells[1].Value.ToString();
            txtdescription.Text = dgvcategories.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtcategoryid.Text);
            c.title = txttitle.Text;
            c.description = txtdescription.Text;
           
            c.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromusername(loggeduser);
            c.added_by = usr.id;

            bool success = dal.UPDATE(c);
            if (success == true)
            {
                MessageBox.Show("User Updated Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed Updated user");
            }
            DataTable dt = dal.Select();
            dgvcategories.DataSource = dt;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtcategoryid.Text);
            bool success = dal.DELETE(c);
            if (success == true)
            {
                MessageBox.Show("User Deleted Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete user");
            }
            DataTable dt = dal.Select();
            dgvcategories.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvcategories.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Search(keywords);
                dgvcategories.DataSource = dt;
            }
        }
    }


}

