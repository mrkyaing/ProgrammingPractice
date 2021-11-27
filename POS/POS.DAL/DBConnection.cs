using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connString = @"Server=localhost;Initial Catalog=POS;UID=sa;PWD=sasa";
            try
            {
                SqlConnection conn = new SqlConnection(connString);
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
