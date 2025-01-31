using SaadStationers1.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaadStationers1.DAL
{
    class deacustDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_dea_cust";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data into Database
        public bool INSERT(deacustBLL dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO tbl_dea_cust(type,name,email,contact,address,pre_balance,added_date,added_by)VALUES(@type,@name,@email,@contact,@address,@pre_balance@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@pre_balance", dc.pre_balance);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region update Data in Database
        public bool UPDATE(deacustBLL dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_dea_cust SET type=@type,name=@name,email=@email,contact=@contact,address=@address,added_date=@added_date,added_by=@added_by, pre_balance=@pre_balance WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);
               

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Delete Data From Database
        public bool DELETE(deacustBLL dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_dea_cust  WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", dc.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region search Data from Database
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR type LIKE '%" + keywords + "%' OR email LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Method to search Dealer Or Customer for transaction module
        public deacustBLL searchdealercustomerfortransaction (string keywords)
        {
            deacustBLL dc = new deacustBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT name, contact, email, address from tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'";
                
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dc;
        }
        #endregion
        #region Method to Get ID of dealer and customer on bases of name
        public deacustBLL GetdeacustIDfromname(string Name)
        {
            deacustBLL dc = new deacustBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id  From tbl_dea_cust WHERE name= '"+Name+"'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dc;
        }
        #endregion

    }
}
