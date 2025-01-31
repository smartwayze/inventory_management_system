using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace SaadStationers1.UI
{
    public partial class frmProfitorLoss : Form
    {
        private string connectionString = "server=DESKTOP-C5JNS3B\\SQLEXPRESS;Initial Catalog=saadstationers;Integrated Security=True";
        public frmProfitorLoss()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-PK");
            InitializeComponent();
        }

        private void lbltop_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            decimal totalSales = GetTotal("Sales");
            decimal totalPurchases = GetTotal("Purchase");

            decimal profitOrLoss = totalSales - totalPurchases;

            totalSalesLabel.Text = $"Total Sales: Rs {totalSales:#,##0.00}";
            totalPurchasesLabel.Text = $"Total Purchases: Rs {totalPurchases:#,##0.00}";

            if (profitOrLoss > 0)
            {
                profitLossLabel.Text = $"Profit: Rs {profitOrLoss:#,##0.00}";
            }
            else if (profitOrLoss < 0)
            {
                profitLossLabel.Text = $"Loss: Rs {Math.Abs(profitOrLoss):#,##0.00}";
            }
            else
            {
                profitLossLabel.Text = "No Profit or Loss";
            }
        }

            private decimal GetTotal(string transactionType)
        {
            decimal total = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ISNULL(SUM(grandTotal), 0) FROM tbl_transactions WHERE type = @TransactionType";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionType", transactionType);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            return total;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





        
    

