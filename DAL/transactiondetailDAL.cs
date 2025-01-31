using SaadStationers1.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaadStationers1.DAL
{
    class transactiondetailDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Insert Data into Database
        public bool INSERT_Transactiondetail(transactiondetailBLL dt)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO tbl_transaction_detail(product_id,rate,qty,total,dea_cust_id,added_date,added_by)VALUES(@product_id,@rate,@qty,@total,@dea_cust_id,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@product_id", dt.product_id);
                cmd.Parameters.AddWithValue("@rate", dt.rate);
                cmd.Parameters.AddWithValue("@qty", dt.qty);
                cmd.Parameters.AddWithValue("@total", dt.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", dt.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", dt.added_date);
                cmd.Parameters.AddWithValue("@added_by", dt.added_by);

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
       
    }
}
