using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
