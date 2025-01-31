using SaadStationers1.BLL;
using SaadStationers1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;
using System.IO;

namespace SaadStationers1.UI
{
    public partial class frmbarcode : Form
    {
        public frmbarcode()
        {
            InitializeComponent();
        }
        productsDAL pdal = new productsDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearchproduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearchproduct.Text;
            if (keyword == "")
            {
                txtproductname.Text = "";
                txtinventory.Text = "";
                txtrate.Text = "";
                return;
            }
            productsBLL p = pdal.GetProductsForTransaction(keyword);
            txtproductname.Text = p.name;
            txtinventory.Text = p.qty.ToString();
            txtrate.Text = p.rate.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            // Get the product information from the form
            string productName = txtproductname.Text;
            string productPrice = txtrate.Text;
            string productInfo = $"{productName}, Price: {productPrice}, Inventory: {txtinventory.Text}";

            // Generate a Code128 barcode with the product information
            BarcodeDraw barcodeDraw = BarcodeDrawFactory.Code128WithChecksum;

            // Generate the barcode image
            Image barcodeImage = barcodeDraw.Draw(productInfo, 100); // Increased resolution for clarity

            // Resize the barcode image to desired dimensions
            barcodeImage = new Bitmap(barcodeImage, new Size(250, 100)); // Increased size for clarity

            // Create a new bitmap to accommodate text above and below the barcode
            Bitmap barcodeWithText = new Bitmap(barcodeImage.Width, barcodeImage.Height + 100); // Additional space for text

            using (Graphics graphics = Graphics.FromImage(barcodeWithText))
            {
                // Draw the barcode image on the new bitmap
                graphics.DrawImage(barcodeImage, 0, 40); // Leave space for the company name

                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                // Draw the company name above the barcode
                Font companyNameFont = new Font("Times New Roman", 12, FontStyle.Bold); // Font style bold
                Font productDetailsFont = new Font("Times New Roman", 10, FontStyle.Bold); // Font style bold

                // Modify the font style to semi-bold for company name and product details
                companyNameFont = new Font(companyNameFont.FontFamily, companyNameFont.Size, FontStyle.Bold); // Combine styles for semi-bold
                productDetailsFont = new Font(productDetailsFont.FontFamily, productDetailsFont.Size, FontStyle.Bold); // Combine styles for semi-bold

                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Draw the company name above the barcode
                graphics.DrawString("Malik Stationers and Uniform center", companyNameFont, Brushes.Black, new RectangleF(0, 0, barcodeImage.Width, 40), stringFormat);

                // Draw the product details (name and price) below the barcode
                string productDetails = $"{productName}\nPrice: {productPrice}";
                graphics.DrawString(productDetails, productDetailsFont, Brushes.Black, new RectangleF(0, barcodeImage.Height + 30, barcodeImage.Width, 80), stringFormat);
            }

            // Get the desktop path
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Combine the desktop path with a subfolder name (if needed)
            string subfolderName = "BarcodeImages"; // Change this as needed
            string folderPath = Path.Combine(desktopPath, subfolderName);

            // Check if the directory exists, and create it if not
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Save the barcode with company name and product details as an image in the specified directory
            string barcodeImagePath = Path.Combine(folderPath, "ProductBarcodeWithNameAndDetails.png");
            barcodeWithText.Save(barcodeImagePath, ImageFormat.Png);

            // Display the barcode using the default image viewer
            System.Diagnostics.Process.Start(barcodeImagePath);

            MessageBox.Show("Barcode with company name and product details generated and saved on the desktop.");
        }
    }
}
