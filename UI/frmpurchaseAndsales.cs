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
using System.Transactions;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.IO;
using SaadStationers1.Reports;

namespace SaadStationers1.UI
{
    public partial class frmpurchaseAndsales : Form
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public frmpurchaseAndsales()
        {
            InitializeComponent();
        }
        deacustDAL dcdal = new deacustDAL();
        productsDAL pdal = new productsDAL();
        DataTable transactionDT = new DataTable();
        private object grandtotalwithvat;
        userDAL udal = new userDAL();
        transactionDAL tdal = new transactionDAL();
        transactiondetailBLL ddt = new transactiondetailBLL();
        transactiondetailDAL tddal = new transactiondetailDAL();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmpurchaseAndsales_Load(object sender, EventArgs e)
        {
            string type = frmuserdashboard.transactiontype;
            lbltop.Text = type;
            dgvaddedproducts.AllowUserToAddRows = false;
            dgvaddedproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
            dgvaddedproducts.DataSource = transactionDT;

            // Calculate and set column widths based on the available width
            if (dgvaddedproducts.Columns.Count >= 4)
            {
                int columnWidth = dgvaddedproducts.Width / 4;
                dgvaddedproducts.Columns[0].Width = columnWidth;
                dgvaddedproducts.Columns[1].Width = columnWidth;
                dgvaddedproducts.Columns[2].Width = columnWidth;
                dgvaddedproducts.Columns[3].Width = columnWidth;
            }
        }
      
        private void txtsearchdeaandcust_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearchdeaandcust.Text;
            if (keyword == "")
            {
                txtdeaandcustname.Text = "";
                txtemail.Text = "";
                txtcontact.Text = "";
                txtaddress.Text = "";
                return;
            }
            deacustBLL dc = dcdal.searchdealercustomerfortransaction(keyword);
            txtdeaandcustname.Text = dc.name;
            txtemail.Text = dc.email;
            txtcontact.Text = dc.contact;
            txtaddress.Text = dc.address;

        }
        private void textsearchproduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearchproduct.Text;
            if (keyword == "")
            {
                txtproductname.Text = "";
                txtinventory.Text = "";
                txtrate.Text = "";
                txtqty.Text = "";

                return;
            }
            productsBLL p = pdal.GetProductsForTransaction(keyword);
            txtproductname.Text = p.name;
            txtinventory.Text = p.qty.ToString();
            txtrate.Text = p.rate.ToString();
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string productname = txtproductname.Text;
            decimal Rate = decimal.Parse(txtrate.Text);
            decimal Qty = decimal.Parse(txtqty.Text);
            decimal Total = Rate * Qty;

            decimal subTotal = decimal.Parse(txtsubtotal.Text);
            subTotal = subTotal + Total;

            if (productname == "")
            {
                MessageBox.Show("Select the product first .Try Again");
            }
            else
            {
                transactionDT.Rows.Add(productname, Rate, Qty, Total);
                dgvaddedproducts.DataSource = transactionDT;
                txtsubtotal.Text = subTotal.ToString();

                txtsearchproduct.Text = "";
                txtproductname.Text = "";
                txtinventory.Text = "0.00";
                txtrate.Text = "0.00";
                txtqty.Text = "0.00";

            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtdiscount.Text;
            if (value == "")
            {
                MessageBox.Show("Please Add Discount First");
            }
            else
            {
                decimal subtotal = decimal.Parse(txtsubtotal.Text);
                decimal discount = decimal.Parse(txtdiscount.Text);
                decimal GrandTotal = ((100 - discount) / 100) * subtotal;
                txtgrandtotal.Text = GrandTotal.ToString();
            }
        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            string check = txtgrandtotal.Text;
            if (check == "")
            {
                MessageBox.Show("Calculate the discount and set the Grand Total First");
            }
            else
            {
                decimal subtotal = 0;
                foreach (DataGridViewRow row in dgvaddedproducts.Rows)
                {
                    if (row.Cells[3].Value != null)
                    {
                        subtotal += decimal.Parse(row.Cells[3].Value.ToString());
                    }
                }

                

                // Calculate the discount amount
                if (decimal.TryParse(txtdiscount.Text, out decimal discountPercentage))
                {
                    decimal discountAmount = (discountPercentage / 100) * subtotal;
                   

                    // Calculate the tax amount
                    if (decimal.TryParse(txtvat.Text, out decimal taxPercentage))
                    {
                        decimal taxAmount = (taxPercentage / 100) * subtotal;
                       

                        // Calculate the grand total
                        decimal grandTotal = subtotal - discountAmount + taxAmount;
                        

                        // Display the grand total
                        txtgrandtotal.Text = grandTotal.ToString();
                    }
                }

            }
        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = Math.Round(decimal.Parse(txtgrandtotal.Text), 2);
            decimal paidamount = decimal.Parse(txtpaidamount.Text);
            decimal returnamount = paidamount - grandTotal;
            txtreturnamount.Text = returnamount.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            transactionBLL transaction = new transactionBLL();
            transaction.type = lbltop.Text;
            string deacustname = txtdeaandcustname.Text;
            deacustBLL dc = dcdal.GetdeacustIDfromname(deacustname);
            transaction.dea_cust_id = dc.id;
            transaction.grandtotal = Math.Round(decimal.Parse(txtgrandtotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            // Calculate VAT on the original subtotal
            decimal originalSubtotal = decimal.Parse(txtsubtotal.Text);
            decimal vat = decimal.Parse(txtvat.Text);
            decimal vatAmount = (vat / 100) * originalSubtotal;

            // Store the tax amount in the transaction object
            transaction.tax = vatAmount;
            // Convert discount percentage to a decimal value
            if (decimal.TryParse(txtdiscount.Text, out decimal discountPercentage))
            {
                // Calculate the discount amount
                decimal subtotal = decimal.Parse(txtsubtotal.Text);
                decimal discountAmount = (discountPercentage / 100) * subtotal;
                transaction.discount = discountAmount;
            }
            string username = frmLogin.loggedIn;
            userBLL u = udal.GetIDfromusername(username);
            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;
            bool success = false;
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                bool w = tdal.INSERT_Transaction(transaction, out transactionID);
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    transactiondetailBLL transactiondetail = new transactiondetailBLL();
                    String ProductName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pdal.GetproductIDfromname(ProductName);
                    transactiondetail.product_id = p.id;
                    transactiondetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactiondetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactiondetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactiondetail.dea_cust_id = dc.id;
                    transactiondetail.added_date = DateTime.Now;
                    transactiondetail.added_by = u.id;
                    string transactionType = lbltop.Text;
                    bool x = false;
                    if (transactionType == "Purchase")
                    {
                        x = pdal.IncreaseProduct(transactiondetail.product_id, transactiondetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {
                        x = pdal.DecreaseProduct(transactiondetail.product_id, transactiondetail.qty);
                    }
                    bool y = tddal.INSERT_Transactiondetail(transactiondetail);
                    success = w && x && y;
                }

                string transactiontype = lbltop.Text;
                if (transactiontype == "Sales")
                {


                    // Create an instance of your Crystal Report
                    ReportDocument report = new ReportDocument();
                    report.Load("C:\\Users\\Umer\\source\\repos\\MalikStationersandUniform\\SaadStationers1\\Reports\\CrystalReport2.rpt"); // Replace with the actual path to your .rpt file


                    // Create a DataTable to hold the data from the DataGridView
                    DataTable dataForReport = new DataTable();

                    // Iterate through the DataGridView and populate the DataTable
                    foreach (DataGridViewColumn column in dgvaddedproducts.Columns)
                    {
                        dataForReport.Columns.Add(column.HeaderText);
                    }

                    foreach (DataGridViewRow row in dgvaddedproducts.Rows)
                    {
                        DataRow dataRow = dataForReport.NewRow();
                        for (int i = 0; i < dgvaddedproducts.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value;
                        }
                        dataForReport.Rows.Add(dataRow);
                    }
                    TextObject Subtotal = (TextObject)report.ReportDefinition.Sections["Section4"].ReportObjects["subtotaltext"];
                    Subtotal.Text = txtsubtotal.Text;
                    TextObject tax = (TextObject)report.ReportDefinition.Sections["Section4"].ReportObjects["taxtext"];
                    decimal taxPercentage = decimal.Parse(txtvat.Text);
                    decimal subtotal = decimal.Parse(txtsubtotal.Text);
                    decimal taxAmount = (taxPercentage / 100) * subtotal;
                    tax.Text = $"{taxPercentage}% ({taxAmount:0.00})";
                    // Check if the entered discount value is a valid decimal
                    if (decimal.TryParse(txtdiscount.Text, out discountPercentage))
                    {

                        // Calculate the discount amount
                        decimal subtotal1 = decimal.Parse(txtsubtotal.Text);
                        decimal discountAmount = (discountPercentage / 100) * subtotal1;
                        TextObject dis = (TextObject)report.ReportDefinition.Sections["Section4"].ReportObjects["distext"];
                        // Display the discount both as a percentage and an amount
                        dis.Text = $"{discountPercentage}% ({discountAmount:0.00})";
                    }
                    TextObject grandtotal = (TextObject)report.ReportDefinition.Sections["Section4"].ReportObjects["grandtotaltext"];
                    grandtotal.Text = txtgrandtotal.Text;
                    TextObject paidamount = (TextObject)report.ReportDefinition.Sections["Section4"].ReportObjects["paidtext"];
                    paidamount.Text = txtpaidamount.Text;
                    TextObject returnamount = (TextObject)report.ReportDefinition.Sections["Section4"].ReportObjects["returntext"];
                    returnamount.Text = txtreturnamount.Text;
                    // Set the DataTable as the report's data source
                    report.SetDataSource(dataForReport);

                    // Create a form to display the report
                    Form reportForm = new Form();

                    // Create a CrystalReportViewer and add it to the form
                    CrystalReportViewer crystalReportViewer = new CrystalReportViewer
                    {
                        Dock = DockStyle.Fill,
                        ReportSource = report
                    };
                    reportForm.Controls.Add(crystalReportViewer);
                    // Show the form with the report
                    reportForm.WindowState = FormWindowState.Maximized;
                    reportForm.ShowDialog();
                }

                if (success == true)
                {
                    scope.Complete();
                    MessageBox.Show("Transaction Completed Successfuly");
                    dgvaddedproducts.DataSource = null;
                    dgvaddedproducts.Rows.Clear();
                    txtsearchdeaandcust.Text = "";
                    txtdeaandcustname.Text = "";
                    txtemail.Text = "";
                    txtcontact.Text = "";
                    txtaddress.Text = "";
                    txtproductname.Text = "";
                    txtinventory.Text = "";
                    txtrate.Text = "";
                    txtqty.Text = "";
                    txtsubtotal.Text = "0";
                    txtdiscount.Text = "0";
                    txtvat.Text = "0";
                    txtgrandtotal.Text = "0";
                    txtpaidamount.Text = "0";
                    txtreturnamount.Text = "0";
                }
                else
                {
                    MessageBox.Show("Transaction failed");
                }
            }
           
        }

        private void txtrate_TextChanged(object sender, EventArgs e)
        {
            string transactionType = lbltop.Text;
            if (transactionType == "Sales")
            {
                txtrate.ReadOnly = true;
            }

        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string productName = txtproductname.Text;
            decimal rate = decimal.Parse(txtrate.Text);
            int quantity = int.Parse(txtqty.Text);

            // Calculate the total
            decimal total = rate * quantity;

            // Update the DataGridView
            dgvaddedproducts.CurrentRow.Cells[0].Value = productName;
            dgvaddedproducts.CurrentRow.Cells[1].Value = rate;
            dgvaddedproducts.CurrentRow.Cells[2].Value = quantity;
            dgvaddedproducts.CurrentRow.Cells[3].Value = total;
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvaddedproducts.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    subtotal += decimal.Parse(row.Cells[3].Value.ToString());
                }
            }

            txtsubtotal.Text = subtotal.ToString();
            txtsearchproduct.Text = "";
            txtproductname.Text = "";
            txtinventory.Text = "0.00";
            txtrate.Text = "0.00";
            txtqty.Text = "0.00";
        }
        
        private void dgvaddedproducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtproductname.Text = dgvaddedproducts.CurrentRow.Cells[0].Value.ToString();
            txtrate.Text = dgvaddedproducts.CurrentRow.Cells[1].Value.ToString();
            txtqty.Text = dgvaddedproducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvaddedproducts_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvaddedproducts.SelectedRows)
            {
                dgvaddedproducts.Rows.Remove(row);
            }
            // Recalculate and update the subtotal after deleting a row
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgvaddedproducts.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    subtotal += decimal.Parse(row.Cells[3].Value.ToString());
                }
            }
            txtsubtotal.Text = subtotal.ToString();
            txtsearchproduct.Text = "";
            txtproductname.Text = "";
            txtinventory.Text = "0.00";
            txtrate.Text = "0.00";
            txtqty.Text = "0.00";
        }

        
    }
}