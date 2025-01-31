
namespace SaadStationers1.UI
{
    partial class frmCalculateprice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculateprice));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcarriage = new System.Windows.Forms.Label();
            this.lblprofit = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.purchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.carriagePercentageTextBox = new System.Windows.Forms.TextBox();
            this.profitPercentageTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateProfitButton = new System.Windows.Forms.Button();
            this.totalValueTextBox = new System.Windows.Forms.TextBox();
            this.profitPercentageTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saleProfitLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.perPiecePriceLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.paneltop.Controls.Add(this.pictureBox1);
            this.paneltop.Controls.Add(this.lbltop);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(775, 37);
            this.paneltop.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(741, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Location = new System.Drawing.Point(279, 9);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(192, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Calculate Price and Profit";
            this.lbltop.Click += new System.EventHandler(this.lbltop_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(45, 118);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(96, 17);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Purchase Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Calculate Price of Product";
            // 
            // lblcarriage
            // 
            this.lblcarriage.AutoSize = true;
            this.lblcarriage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarriage.Location = new System.Drawing.Point(47, 163);
            this.lblcarriage.Name = "lblcarriage";
            this.lblcarriage.Size = new System.Drawing.Size(77, 17);
            this.lblcarriage.TabIndex = 10;
            this.lblcarriage.Text = "Carriage(%)";
            // 
            // lblprofit
            // 
            this.lblprofit.AutoSize = true;
            this.lblprofit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofit.Location = new System.Drawing.Point(48, 196);
            this.lblprofit.Name = "lblprofit";
            this.lblprofit.Size = new System.Drawing.Size(60, 17);
            this.lblprofit.TabIndex = 11;
            this.lblprofit.Text = "Profit(%)";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.Location = new System.Drawing.Point(48, 237);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(61, 17);
            this.lblquantity.TabIndex = 12;
            this.lblquantity.Text = "Quantity";
            // 
            // purchasePriceTextBox
            // 
            this.purchasePriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasePriceTextBox.Location = new System.Drawing.Point(147, 115);
            this.purchasePriceTextBox.Name = "purchasePriceTextBox";
            this.purchasePriceTextBox.Size = new System.Drawing.Size(195, 25);
            this.purchasePriceTextBox.TabIndex = 13;
            // 
            // carriagePercentageTextBox
            // 
            this.carriagePercentageTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carriagePercentageTextBox.Location = new System.Drawing.Point(147, 155);
            this.carriagePercentageTextBox.Name = "carriagePercentageTextBox";
            this.carriagePercentageTextBox.Size = new System.Drawing.Size(195, 25);
            this.carriagePercentageTextBox.TabIndex = 14;
            // 
            // profitPercentageTextBox
            // 
            this.profitPercentageTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitPercentageTextBox.Location = new System.Drawing.Point(147, 193);
            this.profitPercentageTextBox.Name = "profitPercentageTextBox";
            this.profitPercentageTextBox.Size = new System.Drawing.Size(195, 25);
            this.profitPercentageTextBox.TabIndex = 15;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(147, 234);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(195, 25);
            this.quantityTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Calculate Profit of Current Bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total Bill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Profit(%)";
            // 
            // CalculateProfitButton
            // 
            this.CalculateProfitButton.BackColor = System.Drawing.Color.DarkCyan;
            this.CalculateProfitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateProfitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateProfitButton.ForeColor = System.Drawing.Color.White;
            this.CalculateProfitButton.Location = new System.Drawing.Point(571, 217);
            this.CalculateProfitButton.Name = "CalculateProfitButton";
            this.CalculateProfitButton.Size = new System.Drawing.Size(144, 54);
            this.CalculateProfitButton.TabIndex = 23;
            this.CalculateProfitButton.Text = "Calculate Sale Profit";
            this.CalculateProfitButton.UseVisualStyleBackColor = false;
            this.CalculateProfitButton.Click += new System.EventHandler(this.CalculateProfitButton_Click);
            // 
            // totalValueTextBox
            // 
            this.totalValueTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueTextBox.Location = new System.Drawing.Point(520, 115);
            this.totalValueTextBox.Name = "totalValueTextBox";
            this.totalValueTextBox.Size = new System.Drawing.Size(231, 25);
            this.totalValueTextBox.TabIndex = 24;
            this.totalValueTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // profitPercentageTextBox2
            // 
            this.profitPercentageTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitPercentageTextBox2.Location = new System.Drawing.Point(520, 160);
            this.profitPercentageTextBox2.Name = "profitPercentageTextBox2";
            this.profitPercentageTextBox2.Size = new System.Drawing.Size(231, 25);
            this.profitPercentageTextBox2.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.saleProfitLabel);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(516, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(235, 139);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Sale Profit";
            // 
            // saleProfitLabel
            // 
            this.saleProfitLabel.AutoSize = true;
            this.saleProfitLabel.BackColor = System.Drawing.Color.Teal;
            this.saleProfitLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleProfitLabel.Location = new System.Drawing.Point(25, 68);
            this.saleProfitLabel.Name = "saleProfitLabel";
            this.saleProfitLabel.Size = new System.Drawing.Size(23, 25);
            this.saleProfitLabel.TabIndex = 5;
            this.saleProfitLabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.perPiecePriceLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(147, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(195, 83);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Per Piece price";
            // 
            // perPiecePriceLabel
            // 
            this.perPiecePriceLabel.AutoSize = true;
            this.perPiecePriceLabel.BackColor = System.Drawing.Color.Teal;
            this.perPiecePriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perPiecePriceLabel.Location = new System.Drawing.Point(6, 29);
            this.perPiecePriceLabel.Name = "perPiecePriceLabel";
            this.perPiecePriceLabel.Size = new System.Drawing.Size(23, 25);
            this.perPiecePriceLabel.TabIndex = 5;
            this.perPiecePriceLabel.Text = "0";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DarkCyan;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(177, 276);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(144, 54);
            this.CalculateButton.TabIndex = 28;
            this.CalculateButton.Text = "Calculate Price";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // frmCalculateprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(775, 461);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.profitPercentageTextBox2);
            this.Controls.Add(this.totalValueTextBox);
            this.Controls.Add(this.CalculateProfitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.profitPercentageTextBox);
            this.Controls.Add(this.carriagePercentageTextBox);
            this.Controls.Add(this.purchasePriceTextBox);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblprofit);
            this.Controls.Add(this.lblcarriage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalculateprice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalculateprice";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcarriage;
        private System.Windows.Forms.Label lblprofit;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox purchasePriceTextBox;
        private System.Windows.Forms.TextBox carriagePercentageTextBox;
        private System.Windows.Forms.TextBox profitPercentageTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateProfitButton;
        private System.Windows.Forms.TextBox totalValueTextBox;
        private System.Windows.Forms.TextBox profitPercentageTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label saleProfitLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label perPiecePriceLabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}