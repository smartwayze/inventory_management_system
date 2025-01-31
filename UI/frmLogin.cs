using SaadStationers1.BLL;
using SaadStationers1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaadStationers1.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
       public static string loggedIn;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text.Trim();
            l.password = txtpassword.Text.Trim();
            l.user_type = combousertype.Text.Trim();
            bool success = dal.loginCheck(l);
            if(success==true)
            {
                MessageBox.Show("login Successful");
                loggedIn = l.username;
                switch(l.user_type)
                {
                    case "Admin":
                        {
                            Frmadmindashboard admin = new Frmadmindashboard();
                            admin.Show();
                            this.Hide();

                        }
                        break;
                    case "User":
                        {
                            frmuserdashboard user = new frmuserdashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid User Type");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Failed login , Try again");
            }
        }
    }
}
