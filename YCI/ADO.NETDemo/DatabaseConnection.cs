using System;
using System.Data.SqlClient;

namespace ADO.NETDemo
{
    public class DatabaseConnection
    {
        public void CheckDatabaseConnection()
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=sasa";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                if (con != null)
                {
                    Console.WriteLine("database conneciton is connected");
                    Console.WriteLine("Your connected database name is "+ con.Database);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Occur when connect to database");
            }
        }
    }
}
