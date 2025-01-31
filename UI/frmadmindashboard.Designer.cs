
namespace SaadStationers1
{
    partial class Frmadmindashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelbottom = new System.Windows.Forms.Panel();
            this.labelbottom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustripTop = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitOrLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calulatePriceAndProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblloggedInuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelbottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelbottom.Controls.Add(this.labelbottom);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 547);
            this.panelbottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(1059, 41);
            this.panelbottom.TabIndex = 0;
            // 
            // labelbottom
            // 
            this.labelbottom.AutoSize = true;
            this.labelbottom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbottom.ForeColor = System.Drawing.Color.White;
            this.labelbottom.Location = new System.Drawing.Point(606, 15);
            this.labelbottom.Name = "labelbottom";
            this.labelbottom.Size = new System.Drawing.Size(173, 17);
            this.labelbottom.TabIndex = 0;
            this.labelbottom.Text = "Developed by Umar Sultan";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripTop,
            this.categoriesToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.saleReportToolStripMenuItem,
            this.purchaseReportToolStripMenuItem,
            this.profitOrLossToolStripMenuItem,
            this.calulatePriceAndProfitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1059, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menustripTop
            // 
            this.menustripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menustripTop.Name = "menustripTop";
            this.menustripTop.Size = new System.Drawing.Size(53, 21);
            this.menustripTop.Text = "Users";
            this.menustripTop.Click += new System.EventHandler(this.menustripTop_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(144, 21);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.saleReportToolStripMenuItem.Text = "Sale Report";
            this.saleReportToolStripMenuItem.Click += new System.EventHandler(this.saleReportToolStripMenuItem_Click);
            // 
            // purchaseReportToolStripMenuItem
            // 
            this.purchaseReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            this.purchaseReportToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.purchaseReportToolStripMenuItem.Text = "Purchase Report";
            this.purchaseReportToolStripMenuItem.Click += new System.EventHandler(this.purchaseReportToolStripMenuItem_Click);
            // 
            // profitOrLossToolStripMenuItem
            // 
            this.profitOrLossToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitOrLossToolStripMenuItem.Name = "profitOrLossToolStripMenuItem";
            this.profitOrLossToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.profitOrLossToolStripMenuItem.Text = "Profit or Loss";
            this.profitOrLossToolStripMenuItem.Click += new System.EventHandler(this.profitOrLossToolStripMenuItem_Click);
            // 
            // calulatePriceAndProfitToolStripMenuItem
            // 
            this.calulatePriceAndProfitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calulatePriceAndProfitToolStripMenuItem.Name = "calulatePriceAndProfitToolStripMenuItem";
            this.calulatePriceAndProfitToolStripMenuItem.Size = new System.Drawing.Size(159, 21);
            this.calulatePriceAndProfitToolStripMenuItem.Text = "Calulate Price and Profit";
            this.calulatePriceAndProfitToolStripMenuItem.Click += new System.EventHandler(this.calulatePriceAndProfitToolStripMenuItem_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(15, 50);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(42, 17);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "User :";
            // 
            // lblloggedInuser
            // 
            this.lblloggedInuser.AutoSize = true;
            this.lblloggedInuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloggedInuser.ForeColor = System.Drawing.Color.Red;
            this.lblloggedInuser.Location = new System.Drawing.Point(71, 50);
            this.lblloggedInuser.Name = "lblloggedInuser";
            this.lblloggedInuser.Size = new System.Drawing.Size(0, 17);
            this.lblloggedInuser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Malik Satationers And Uniform Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(501, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Billing and Inventory System";
            // 
            // Frmadmindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblloggedInuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frmadmindashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmadmindashboard_FormClosed);
            this.Load += new System.EventHandler(this.Frmadmindashboard_Load);
            this.panelbottom.ResumeLayout(false);
            this.panelbottom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Label labelbottom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustripTop;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblloggedInuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitOrLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calulatePriceAndProfitToolStripMenuItem;
    }
}