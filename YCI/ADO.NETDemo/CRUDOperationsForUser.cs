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
                string query = "select * from users order by Id";
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
        }//end of GetUserList() 

        public void SaveUser(UserModel user)
        {
            try
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
                    string query = $"insert into users values({user.Id},'{user.UserName}','{user.Email}','{user.Password}','{user.IsDelete}','{user.CreatedDate}')";

                    //step 4) create SqlCommand object 
                    SqlCommand sqlCommmand = new SqlCommand(query, con);//passing your query and your sqlconnection object 

                    //step 5) inserting data to database with ExecuteNonQuery Method of  SqlCommand Object 
                    int result = sqlCommmand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("1 record save to database successfully");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error occur when saving data " + ex.Message);
            }

        }//end of SaveUser Method 


        public void UpdateUser(UserModel user)
        {
            try
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
                    string query = $"update users set UserName='{user.UserName}',Email='{user.Email}' where Id={user.Id}";

                    //step 4) create SqlCommand object 
                    SqlCommand sqlCommmand = new SqlCommand(query, con);//passing your query and your sqlconnection object 

                    //step 5) inserting data to database with ExecuteNonQuery Method of  SqlCommand Object 
                    int result = sqlCommmand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("1 record update to database successfully");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error occur when saving data " + ex.Message);
            }
        }//end of update user method 


        public void DeleteUser(int userId)
        {
            try
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
                    string query = $"delete from users where Id={userId}";

                    //step 4) create SqlCommand object 
                    SqlCommand sqlCommmand = new SqlCommand(query, con);//passing your query and your sqlconnection object 

                    //step 5) inserting data to database with ExecuteNonQuery Method of  SqlCommand Object 
                    int result = sqlCommmand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("1 record delete to database successfully");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error occur when saving data " + ex.Message);
            }
        }
    }
}
