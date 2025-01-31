
namespace SaadStationers1.UI
{
    partial class frmDeaCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeaCust));
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvdeacust = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdeacustid = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldeacustid = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.combtype = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeacust)).BeginInit();
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
            this.paneltop.TabIndex = 3;
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
            this.lbltop.Location = new System.Drawing.Point(283, 9);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(163, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Dealer and Customer";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.Location = new System.Drawing.Point(21, 202);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(55, 17);
            this.lblcontact.TabIndex = 61;
            this.lblcontact.Text = "Contact";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(21, 172);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(40, 17);
            this.lblemail.TabIndex = 59;
            this.lblemail.Text = "Email";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(379, 435);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(127, 36);
            this.btnupdate.TabIndex = 58;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(534, 435);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(124, 36);
            this.btndelete.TabIndex = 57;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(230, 435);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(128, 36);
            this.btnadd.TabIndex = 56;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvdeacust
            // 
            this.dgvdeacust.BackgroundColor = System.Drawing.Color.White;
            this.dgvdeacust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeacust.Location = new System.Drawing.Point(359, 106);
            this.dgvdeacust.Name = "dgvdeacust";
            this.dgvdeacust.Size = new System.Drawing.Size(415, 299);
            this.dgvdeacust.TabIndex = 55;
            this.dgvdeacust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdeacust_RowHeaderMouseClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(433, 67);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(341, 20);
            this.txtsearch.TabIndex = 54;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(356, 70);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(48, 17);
            this.lblsearch.TabIndex = 53;
            this.lblsearch.Text = "Search";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(145, 232);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(175, 173);
            this.txtaddress.TabIndex = 52;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(145, 136);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(175, 20);
            this.txtname.TabIndex = 51;
            // 
            // txtdeacustid
            // 
            this.txtdeacustid.Location = new System.Drawing.Point(145, 67);
            this.txtdeacustid.Name = "txtdeacustid";
            this.txtdeacustid.ReadOnly = true;
            this.txtdeacustid.Size = new System.Drawing.Size(175, 20);
            this.txtdeacustid.TabIndex = 50;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(21, 232);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(57, 17);
            this.lbladdress.TabIndex = 49;
            this.lbladdress.Text = "Address";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(21, 139);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 17);
            this.lblname.TabIndex = 48;
            this.lblname.Text = "Name";
            // 
            // lbldeacustid
            // 
            this.lbldeacustid.AutoSize = true;
            this.lbldeacustid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeacustid.Location = new System.Drawing.Point(21, 67);
            this.lbldeacustid.Name = "lbldeacustid";
            this.lbldeacustid.Size = new System.Drawing.Size(75, 17);
            this.lbldeacustid.TabIndex = 47;
            this.lbldeacustid.Text = "DeaCust ID";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(29, 106);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(36, 17);
            this.lbltype.TabIndex = 64;
            this.lbltype.Text = "Type";
            // 
            // combtype
            // 
            this.combtype.FormattingEnabled = true;
            this.combtype.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.combtype.Location = new System.Drawing.Point(145, 102);
            this.combtype.Name = "combtype";
            this.combtype.Size = new System.Drawing.Size(175, 21);
            this.combtype.TabIndex = 65;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(145, 169);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(175, 20);
            this.txtemail.TabIndex = 66;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(145, 199);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(175, 20);
            this.txtcontact.TabIndex = 67;
            // 
            // frmDeaCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.combtype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvdeacust);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtdeacustid);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbldeacustid);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeaCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeaCust";
            this.Load += new System.EventHandler(this.frmDeaCust_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeacust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvdeacust;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdeacustid;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldeacustid;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.ComboBox combtype;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcontact;
    }
}