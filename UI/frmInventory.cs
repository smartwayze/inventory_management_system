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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DataTable cdt = cdal.Select();
            cmbcategories.DataSource = cdt;
            cmbcategories.DisplayMember = "title";
            cmbcategories.ValueMember = "title";
            DataTable pdt = pdal.Select();
            dgvProducts.DataSource = pdt;
        }

        private void cmbcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbcategories.Text;
            DataTable dt = pdal.DisplayProductsByCategory(category);
            dgvProducts.DataSource = dt;
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }
    }
}
