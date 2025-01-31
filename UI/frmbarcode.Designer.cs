
namespace SaadStationers1.UI
{
    partial class frmbarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbarcode));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.txtsearchproduct = new System.Windows.Forms.TextBox();
            this.labelsearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.pictureBoxbarcode = new System.Windows.Forms.PictureBox();
            this.txtinventory = new System.Windows.Forms.TextBox();
            this.labelinventory = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbarcode)).BeginInit();
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
            this.paneltop.Size = new System.Drawing.Size(606, 33);
            this.paneltop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 0);
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
            this.lbltop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.Location = new System.Drawing.Point(261, 0);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(85, 25);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Barcode";
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(95, 185);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(171, 25);
            this.txtrate.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Rate";
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductname.Location = new System.Drawing.Point(95, 99);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(171, 25);
            this.txtproductname.TabIndex = 19;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(12, 99);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(44, 17);
            this.labelname.TabIndex = 18;
            this.labelname.Text = "Name";
            // 
            // txtsearchproduct
            // 
            this.txtsearchproduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchproduct.Location = new System.Drawing.Point(95, 58);
            this.txtsearchproduct.Name = "txtsearchproduct";
            this.txtsearchproduct.Size = new System.Drawing.Size(171, 25);
            this.txtsearchproduct.TabIndex = 17;
            this.txtsearchproduct.TextChanged += new System.EventHandler(this.txtsearchproduct_TextChanged);
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.Location = new System.Drawing.Point(-131, 226);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(48, 17);
            this.labelsearch.TabIndex = 16;
            this.labelsearch.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-134, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(221, 251);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(166, 45);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "Generate";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pictureBoxbarcode
            // 
            this.pictureBoxbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxbarcode.Location = new System.Drawing.Point(294, 58);
            this.pictureBoxbarcode.Name = "pictureBoxbarcode";
            this.pictureBoxbarcode.Size = new System.Drawing.Size(300, 152);
            this.pictureBoxbarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxbarcode.TabIndex = 26;
            this.pictureBoxbarcode.TabStop = false;
            // 
            // txtinventory
            // 
            this.txtinventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinventory.Location = new System.Drawing.Point(95, 141);
            this.txtinventory.Name = "txtinventory";
            this.txtinventory.ReadOnly = true;
            this.txtinventory.Size = new System.Drawing.Size(171, 25);
            this.txtinventory.TabIndex = 28;
            // 
            // labelinventory
            // 
            this.labelinventory.AutoSize = true;
            this.labelinventory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinventory.Location = new System.Drawing.Point(12, 141);
            this.labelinventory.Name = "labelinventory";
            this.labelinventory.Size = new System.Drawing.Size(68, 17);
            this.labelinventory.TabIndex = 27;
            this.labelinventory.Text = "Inventory";
            // 
            // frmbarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(606, 323);
            this.Controls.Add(this.txtinventory);
            this.Controls.Add(this.labelinventory);
            this.Controls.Add(this.pictureBoxbarcode);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.txtsearchproduct);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmbarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbarcode";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox txtsearchproduct;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pictureBoxbarcode;
        private System.Windows.Forms.TextBox txtinventory;
        private System.Windows.Forms.Label labelinventory;
    }
}