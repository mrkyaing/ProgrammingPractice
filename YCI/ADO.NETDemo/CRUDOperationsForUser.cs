using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO.NETDemo
{
    public class CRUDOperationsForUser
    {
        public void GetUserList()
        {
            //Step 1) define sql server name and password 
            //your connection string here 
            string connectionString = "Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=sasa";

            //step 2) create SqlConnection Object by using System.Data.SqlClient Library 
            SqlConnection con = new SqlConnection(connectionString);
            //Open database Connection  
            con.Open();
            if (con != null)
            {              
                //step 3) define your query statement
                string query = "SELECT * FROM Users";
                //step 4) create SqlCommand object 
                SqlCommand sqlCommmand = new SqlCommand(query,con);//passing your query and your sqlconnection object 
                //step 5) reading data from database with SqlDataReader Object 
                SqlDataReader reader = sqlCommmand.ExecuteReader();
                
                //finally iterate(loop) the all of data until data exists in database.
                while (reader.Read())
                {
                    Console.WriteLine(reader["Id"]);
                    Console.WriteLine(reader["UserName"]);
                    Console.WriteLine(reader["Email"]);
                    Console.WriteLine(reader["IsDelete"]);
                    Console.WriteLine(reader["CreatedDate"]);
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
