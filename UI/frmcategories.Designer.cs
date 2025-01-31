
namespace SaadStationers1.UI
{
    partial class frmcategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcategories));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblcategories = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtcategoryid = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgvcategories = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).BeginInit();
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
            this.paneltop.TabIndex = 1;
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
            this.lbltop.Location = new System.Drawing.Point(355, 9);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(89, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Categories";
            // 
            // lblcategories
            // 
            this.lblcategories.AutoSize = true;
            this.lblcategories.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategories.Location = new System.Drawing.Point(21, 74);
            this.lblcategories.Name = "lblcategories";
            this.lblcategories.Size = new System.Drawing.Size(89, 17);
            this.lblcategories.TabIndex = 2;
            this.lblcategories.Text = "Categories ID";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(21, 136);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(33, 17);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "Title";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(21, 196);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(76, 17);
            this.lbldescription.TabIndex = 4;
            this.lbldescription.Text = "Description";
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.Location = new System.Drawing.Point(145, 74);
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.ReadOnly = true;
            this.txtcategoryid.Size = new System.Drawing.Size(175, 20);
            this.txtcategoryid.TabIndex = 5;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(145, 133);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(175, 20);
            this.txttitle.TabIndex = 6;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(145, 196);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(175, 173);
            this.txtdescription.TabIndex = 7;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(433, 74);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(341, 20);
            this.txtsearch.TabIndex = 9;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(356, 77);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(48, 17);
            this.lblsearch.TabIndex = 8;
            this.lblsearch.Text = "Search";
            // 
            // dgvcategories
            // 
            this.dgvcategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategories.Location = new System.Drawing.Point(359, 113);
            this.dgvcategories.Name = "dgvcategories";
            this.dgvcategories.Size = new System.Drawing.Size(415, 256);
            this.dgvcategories.TabIndex = 10;
            this.dgvcategories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcategories_RowHeaderMouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(343, 392);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(127, 36);
            this.btnupdate.TabIndex = 30;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(498, 392);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(124, 36);
            this.btndelete.TabIndex = 29;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(194, 392);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(128, 36);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // frmcategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvcategories);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtcategoryid);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblcategories);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcategories";
            this.Load += new System.EventHandler(this.frmcategories_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblcategories;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txtcategoryid;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgvcategories;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
    }
}