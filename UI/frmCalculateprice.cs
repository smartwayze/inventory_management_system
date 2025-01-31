using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaadStationers1.UI
{
    public partial class frmCalculateprice : Form
    {
        public frmCalculateprice()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-PK");
            InitializeComponent();
        }

        private void lbltop_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Parse input values
            if (!decimal.TryParse(purchasePriceTextBox.Text, out decimal purchasePrice) ||
                !decimal.TryParse(carriagePercentageTextBox.Text, out decimal carriagePercentage) ||
                !decimal.TryParse(profitPercentageTextBox.Text, out decimal profitPercentage) ||
                !int.TryParse(quantityTextBox.Text, out int quantity))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            // Calculate the per-piece price
            decimal carriageAmount = (carriagePercentage / 100) * purchasePrice;
            decimal totalCost = purchasePrice + carriageAmount;
            decimal profitAmount = (profitPercentage / 100) * totalCost;
            decimal totalPrice = totalCost + profitAmount;
            decimal perPiecePrice = totalPrice / quantity;

            // Display the per-piece price
            perPiecePriceLabel.Text = $"  {perPiecePrice:C}";
            // Clear the input fields
            purchasePriceTextBox.Clear();
            carriagePercentageTextBox.Clear();
            profitPercentageTextBox.Clear();
            quantityTextBox.Clear();
        }

        private void CalculateProfitButton_Click(object sender, EventArgs e)
        {
            // Calculate profit for any sale based on the total value and user-defined profit percentage
            if (decimal.TryParse(totalValueTextBox.Text, out decimal totalValue))
            {
                if (decimal.TryParse(profitPercentageTextBox2.Text, out decimal profitPercentage))
                {
                    decimal profit = totalValue - (totalValue / (1 + (profitPercentage / 100)));
                    saleProfitLabel.Text = $"   {profit:C}";

                }
                else
                {
                    saleProfitLabel.Text = "Invalid profit percentage input.";
                }
            }
            else
            {
                saleProfitLabel.Text = "Invalid total value input.";
            }
            // Clear the input fields
            totalValueTextBox.Clear();
            profitPercentageTextBox2.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
