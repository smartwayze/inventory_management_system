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
    class productsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_product";
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
        public bool INSERT(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO tbl_product(name,categories,description,rate,qty,added_date,added_by)VALUES(@name,@categories,@description,@rate,@qty,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@categories", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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
        public bool UPDATE(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_product SET name=@name,categories=@categories,description=@description,rate=@rate,qty=@qty,added_date=@added_date,added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@categories", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

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
        public bool DELETE(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_product  WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", p.id);

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
                string sql = "SELECT * FROM tbl_product WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR categories LIKE '%" + keywords + "%' OR rate LIKE '%" + keywords + "%'";
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
        #region Method to search product from Transaction Module
        public productsBLL GetProductsForTransaction(string keyword)
        {
            productsBLL p = new productsBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT name, rate, qty from tbl_product WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                    
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
            return p;
        }
        #endregion
        #region Method to Get product id based on name
        public productsBLL GetproductIDfromname(string ProductName)
        {
            productsBLL p = new productsBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id  From tbl_product WHERE name= '" + ProductName + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());

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
            return p;
        }
        #endregion
        #region Method to Get current Quantity from the database on product ID
        public decimal GetproductQty(int ProductID)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            decimal qty = 0;
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT qty  From tbl_product WHERE id= '" + ProductID + "'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());

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
            return qty;
        }
        #endregion
        #region Method to update Quantity
        public bool UpdateQuantity(int ProductID,decimal qty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE  tbl_product SET qty=@qty WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qty",qty);
                cmd.Parameters.AddWithValue("@id",ProductID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;

                }
                else
                {
                    success = false;
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
            return success;
        }
        #endregion
        #region Method to Increase product
        public bool IncreaseProduct(int ProductID,decimal IncreaseQty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                decimal currentQty = GetproductQty(ProductID);
                decimal newqty = currentQty + IncreaseQty;
                success = UpdateQuantity(ProductID, newqty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion
        #region Method to decrease product
        public bool DecreaseProduct(int ProductID,decimal Qty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                decimal currentQty = GetproductQty(ProductID);
                decimal newqty = currentQty - Qty;
                success = UpdateQuantity(ProductID, newqty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        #endregion
        #region Method Display products based on Categories
        public DataTable DisplayProductsByCategory(string category)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_product WHERE categories='" + category + "'";
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
    }
}
