using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAO
{
    public class UserService : IUserDAO
    {
        public bool DeleteUser(string Id)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=sasa";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {              
                con.Open();
                if (con != null)
                {
                    string query = $"delete from users where Id='{Id}'";
                    SqlCommand sqlCommmand = new SqlCommand(query, con);
                    int result=sqlCommmand.ExecuteNonQuery();
                    if(result>0) return true;
                   
                }
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public UserModel GetUserById(string Id)
        {
            UserModel dbUserModel = new UserModel();
            //Step 1) define sql server name and password 
            //your connection string here 
            string connectionString = "Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=sasa";

            //step 2) create SqlConnection Object by using System.Data.SqlClient Library 
            SqlConnection con = new SqlConnection(connectionString);
            //Open database Connection  
            con.Open();
            if (con != null)
            {
                //step 3) define your query statement
                string query = $"select * from users where Id='{Id}' ";
                //step 4) create SqlCommand object 
                SqlCommand sqlCommmand = new SqlCommand(query, con);//passing your query and your sqlconnection object 
                //step 5) reading data from database with SqlDataReader Object 
                SqlDataReader reader = sqlCommmand.ExecuteReader();

                //finally iterate(loop) the all of data until data exists in database.
                while (reader.Read())
                {
                    //data binding to the UserModel from the database Object 
                    dbUserModel.Id = reader["Id"].ToString();
                    dbUserModel.Email = reader["Email"].ToString();
                    dbUserModel.UserName = reader["UserName"].ToString();
                    dbUserModel.Passwrod= reader["Password"].ToString();
                    dbUserModel.Role = reader["Role"].ToString();
                }
                reader.Close();
                con.Close();
            }
            return dbUserModel;
        }

        public List<UserModel> GetUserList()
        {
            List<UserModel> userListData=new List<UserModel>();
            //Step 1) define sql server name and password 
            //your connection string here 
            string connectionString = "Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=sasa";

            //step 2) create SqlConnection Object by using System.Data.SqlClient Library 
            SqlConnection con = new SqlConnection(connectionString);
            //Open database Connection  
            con.Open();
            if (con != null)
            {
                //step 3) define your query statement
                string query = $"select * from users";
                //step 4) create SqlCommand object 
                SqlCommand sqlCommmand = new SqlCommand(query, con);//passing your query and your sqlconnection object 
                //step 5) reading data from database with SqlDataReader Object 
                SqlDataReader reader = sqlCommmand.ExecuteReader();
                //finally iterate(loop) the all of data until data exists in database.
                while (reader.Read())
                {
                    //data binding to the UserModel from the database Object 
                    UserModel userModel = new UserModel()
                    {
                        Id = reader["Id"].ToString(),
                        Email = reader["Email"].ToString(),
                        UserName = reader["UserName"].ToString()
                    };
                    if (!(reader["Role"] is DBNull))
                    {
                        userModel.Role = reader["Role"].ToString();
                    }
                    userListData.Add(userModel);
                }
                reader.Close();
                con.Close();            
            }
            return userListData;
        }

        public UserModel GetUserListByUserNameAndPassword(string UserName, string Password)
        {
            UserModel dbUserModel = new UserModel();
            //Step 1) define sql server name and password 
            //your connection string here 
            string connectionString = "Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=sasa";

            //step 2) create SqlConnection Object by using System.Data.SqlClient Library 
            SqlConnection con = new SqlConnection(connectionString);
            //Open database Connection  
            con.Open();
            if (con != null)
            {
                //step 3) define your query statement
                string query = $"select * from users where UserName='{UserName}' AND Password='{Password}' ";
                //step 4) create SqlCommand object 
                SqlCommand sqlCommmand = new SqlCommand(query, con);//passing your query and your sqlconnection object 
                //step 5) reading data from database with SqlDataReader Object 
                SqlDataReader reader = sqlCommmand.ExecuteReader();
               
                //finally iterate(loop) the all of data until data exists in database.
                while (reader.Read())
                {
                    //data binding to the UserModel from the database Object 
                    dbUserModel.Id = reader["Id"].ToString();
                    dbUserModel.Email = reader["Email"].ToString();
                    dbUserModel.UserName = reader["UserName"].ToString();
                    
                    
                }
                reader.Close();
                con.Close();
            }
            return dbUserModel;
        }

        public void SaveUser(UserModel user)
        {
            try
            {
                //Step 1) define sql server name and password 
                //your connection string here 
                string connectionString = "Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=sasa";

                //step 2) create SqlConnection Object by using System.Data.SqlClient Library 
                SqlConnection con = new SqlConnection(connectionString);
                //Open database Connection  
                con.Open();
                if (con != null)
                {
                    //step 3) define your query statement
                    string query = $"insert into users values('{user.Id}','{user.UserName}','{user.Email}','{user.Passwrod}','{user.Role}')";

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
        }

        public bool UpdateUser(UserModel user)
        {
            try
            {
                //Step 1) define sql server name and password 
                //your connection string here 
                string connectionString = "Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=sasa";

                //step 2) create SqlConnection Object by using System.Data.SqlClient Library 
                SqlConnection con = new SqlConnection(connectionString);
                //Open database Connection  
                con.Open();
                if (con != null)
                {
                    //step 3) define your query statement
                    string query = $"update users set UserName='{user.UserName}',Email='{user.Email}',Password='{user.Passwrod}',Role='{user.Role}' where Id='{user.Id}'";

                    //step 4) create SqlCommand object 
                    SqlCommand sqlCommmand = new SqlCommand(query, con);//passing your query and your sqlconnection object 

                    //step 5) inserting data to database with ExecuteNonQuery Method of  SqlCommand Object 
                    int result = sqlCommmand.ExecuteNonQuery();
                    if (result > 0)
                    {
                       return true;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error occur when updating data " + ex.Message);
            }
            return false;
        }
    }
}
