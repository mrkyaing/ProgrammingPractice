using System.Data.SqlClient;
namespace HRMS
{
    public class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                string connectionString = "Server=localhost;Initial Catalog=master;Integrated Security=True;User Id=sa;Password=sasa";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
