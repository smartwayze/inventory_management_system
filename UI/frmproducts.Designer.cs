
namespace SaadStationers1.UI
{
    partial class frmproducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproducts));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblproductid = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.lblrate = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
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
            this.paneltop.Size = new System.Drawing.Size(800, 37);
            this.paneltop.TabIndex = 2;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(763, 1);
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
            this.lbltop.Location = new System.Drawing.Point(334, 9);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(75, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Products";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(384, 440);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(127, 36);
            this.btnupdate.TabIndex = 42;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(539, 440);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(124, 36);
            this.btndelete.TabIndex = 41;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(235, 440);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(128, 36);
            this.btnadd.TabIndex = 40;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvproducts
            // 
            this.dgvproducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Location = new System.Drawing.Point(364, 111);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.Size = new System.Drawing.Size(415, 299);
            this.dgvproducts.TabIndex = 39;
            this.dgvproducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproducts_RowHeaderMouseClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(438, 72);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(341, 20);
            this.txtsearch.TabIndex = 38;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(361, 75);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(48, 17);
            this.lblsearch.TabIndex = 37;
            this.lblsearch.Text = "Search";
            this.lblsearch.Click += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(150, 194);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(175, 173);
            this.txtdescription.TabIndex = 36;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(150, 108);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(175, 20);
            this.txtname.TabIndex = 35;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(150, 72);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.ReadOnly = true;
            this.txtproductid.Size = new System.Drawing.Size(175, 20);
            this.txtproductid.TabIndex = 34;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(26, 194);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(76, 17);
            this.lbldescription.TabIndex = 33;
            this.lbldescription.Text = "Description";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(26, 111);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 17);
            this.lblname.TabIndex = 32;
            this.lblname.Text = "Name";
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(26, 72);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(73, 17);
            this.lblproductid.TabIndex = 31;
            this.lblproductid.Text = "Product ID";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(26, 149);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(64, 17);
            this.lblcategory.TabIndex = 43;
            this.lblcategory.Text = "Category";
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(150, 145);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(175, 21);
            this.cmbcategory.TabIndex = 44;
            // 
            // lblrate
            // 
            this.lblrate.AutoSize = true;
            this.lblrate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrate.Location = new System.Drawing.Point(28, 393);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(35, 17);
            this.lblrate.TabIndex = 45;
            this.lblrate.Text = "Rate";
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(150, 389);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(175, 20);
            this.txtrate.TabIndex = 46;
            // 
            // frmproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.lblrate);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvproducts);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblproductid);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmproducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmproducts";
            this.Load += new System.EventHandler(this.frmproducts_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.TextBox txtrate;
    }
}