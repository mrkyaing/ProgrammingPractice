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
                //your connection string here 
                string connectionString = "Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=sasa";
                //create SqlConneciton Object from using System.Data.SqlClient Library 
                SqlConnection con = new SqlConnection(connectionString);
                //Open database Connection Here 
                con.Open();
                if (con != null)
                {
                    Console.WriteLine("database conneciton is connected");
                    Console.WriteLine("Your connected database name is "+ con.Database);
                }
            }
            catch (SqlException ex)
            {
                //Error occur 
                Console.WriteLine("Error Occur when connect to database");
            }
        }
    }
}
