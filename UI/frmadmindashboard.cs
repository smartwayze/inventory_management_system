using SaadStationers1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaadStationers1
{
    public partial class Frmadmindashboard : Form
    {
        public Frmadmindashboard()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menustripTop_Click(object sender, EventArgs e)
        {
            frmusers user = new frmusers();
            user.Show();
        }

        private void Frmadmindashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void Frmadmindashboard_Load(object sender, EventArgs e)
        {
            lblloggedInuser.Text = frmLogin.loggedIn;
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategories categories = new frmcategories();
            categories.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproducts product = new frmproducts();
            product.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions Transactions = new frmTransactions();
            Transactions.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust deacust = new frmDeaCust();
            deacust.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory Inventory = new frmInventory();
            Inventory.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsaleReports SaleReport = new frmsaleReports();
            SaleReport.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseReport purchaseReport = new frmPurchaseReport();
            purchaseReport.Show();
        }

        private void profitOrLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfitorLoss profitorLoss = new frmProfitorLoss();
            profitorLoss.Show();
        }

        private void calulatePriceAndProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculateprice calculateprice = new frmCalculateprice();
            calculateprice.Show();
        }
    }
}
