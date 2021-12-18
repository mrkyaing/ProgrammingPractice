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
                    dbUserModel.Id =Convert.ToInt32(reader["Id"]);
                    dbUserModel.Email = reader["Email"].ToString();
                    dbUserModel.UserName = reader["UserName"].ToString();
                }
                reader.Close();
                con.Close();
            }
            return dbUserModel;
        }
    }
}
