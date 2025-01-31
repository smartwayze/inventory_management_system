
namespace SaadStationers1.UI
{
    partial class frmProfitorLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfitorLoss));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.gbprofit = new System.Windows.Forms.GroupBox();
            this.profitLossLabel = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalPurchasesLabel = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbprofit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.paneltop.Size = new System.Drawing.Size(946, 37);
            this.paneltop.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(912, 0);
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
            this.lbltop.Location = new System.Drawing.Point(428, 9);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(109, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Profit Or Loss";
            this.lbltop.Click += new System.EventHandler(this.lbltop_Click);
            // 
            // gbprofit
            // 
            this.gbprofit.BackColor = System.Drawing.Color.ForestGreen;
            this.gbprofit.Controls.Add(this.profitLossLabel);
            this.gbprofit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbprofit.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbprofit.ForeColor = System.Drawing.Color.White;
            this.gbprofit.Location = new System.Drawing.Point(285, 345);
            this.gbprofit.Name = "gbprofit";
            this.gbprofit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbprofit.Size = new System.Drawing.Size(402, 187);
            this.gbprofit.TabIndex = 14;
            this.gbprofit.TabStop = false;
            this.gbprofit.Text = "Profit OR Loss";
            // 
            // profitLossLabel
            // 
            this.profitLossLabel.AutoSize = true;
            this.profitLossLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.profitLossLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLossLabel.Location = new System.Drawing.Point(6, 81);
            this.profitLossLabel.Name = "profitLossLabel";
            this.profitLossLabel.Size = new System.Drawing.Size(34, 40);
            this.profitLossLabel.TabIndex = 5;
            this.profitLossLabel.Text = "0";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(420, 65);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(117, 39);
            this.btncalculate.TabIndex = 18;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.totalSalesLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(435, 187);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Sale";
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.totalSalesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.Location = new System.Drawing.Point(6, 81);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(29, 32);
            this.totalSalesLabel.TabIndex = 5;
            this.totalSalesLabel.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.totalPurchasesLabel);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(484, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(439, 187);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Purchase";
            // 
            // totalPurchasesLabel
            // 
            this.totalPurchasesLabel.AutoSize = true;
            this.totalPurchasesLabel.BackColor = System.Drawing.Color.Teal;
            this.totalPurchasesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPurchasesLabel.Location = new System.Drawing.Point(6, 81);
            this.totalPurchasesLabel.Name = "totalPurchasesLabel";
            this.totalPurchasesLabel.Size = new System.Drawing.Size(29, 32);
            this.totalPurchasesLabel.TabIndex = 5;
            this.totalPurchasesLabel.Text = "0";
            // 
            // frmProfitorLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(946, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.gbprofit);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfitorLoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfitorLoss";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbprofit.ResumeLayout(false);
            this.gbprofit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.GroupBox gbprofit;
        private System.Windows.Forms.Label profitLossLabel;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label totalPurchasesLabel;
    }
}