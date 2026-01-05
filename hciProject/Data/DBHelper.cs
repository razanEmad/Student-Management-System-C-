using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace hciProject.Data 
{
    class DBHelper
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentSystemDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con;

        public DBHelper()
        {
            con = new SqlConnection(connectionString);
        }

    
        public DataTable ExecuteQuery(string queryText)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(queryText, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الاتصال: " + ex.Message);
            }
            return dt;
        }

        public int ExecuteNonQuery(string queryText)
        {
            int rowsAffected = 0;
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand(queryText, con);
                rowsAffected = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التنفيذ: " + ex.Message);
                con.Close();
            }
            return rowsAffected;
        }
    }
}