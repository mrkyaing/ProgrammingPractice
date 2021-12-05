using POS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    public class UserDataController
    {
        public List<UserModel> GetUserList()
        {
            var users=new List<UserModel>();
            SqlConnection sqlConnection=DBConnection.GetConnection();
            string sql = "SELECT * From [User] where IsDelete=0;";
            SqlCommand sqlCommand=new SqlCommand(sql,sqlConnection);
            SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                UserModel user = new UserModel()
                {
                    Id = sqlDataReader["Id"].ToString(),
                    UserName = sqlDataReader["UserName"].ToString(),
                    Email = sqlDataReader["Email"].ToString(),
                    CreatedDate = Convert.ToDateTime(sqlDataReader["CreatedDate"]),
                };
                if (!(sqlDataReader["UpdatedDate"] is DBNull))
                {
                    user.UpdatedDate = Convert.ToDateTime(sqlDataReader["UpdatedDate"]);
                }
            users.Add(user);
            }
            sqlConnection.Close();
            return users;
        }

        public UserModel GetUserListById(string userId)
        {        
            SqlConnection sqlConnection = DBConnection.GetConnection();
            string query = $"SELECT * From [User] where IsDelete=0 and Id='{userId}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            UserModel userModel = new UserModel();
            while (sqlDataReader.Read())
            {
                userModel.UserName = sqlDataReader["UserName"].ToString();
                userModel.Email = sqlDataReader["Email"].ToString();
                userModel.Password = sqlDataReader["Password"].ToString();
                userModel.CreatedDate = Convert.ToDateTime(sqlDataReader["CreatedDate"]);
                if (!(sqlDataReader["UpdatedDate"] is DBNull))
                {
                    userModel.UpdatedDate = Convert.ToDateTime(sqlDataReader["UpdatedDate"]);
                }
            }
            sqlConnection.Close();
            return userModel;
        }

        public UserModel GetUserByUserNameAndPassword(string userName,string password)
        {
            SqlConnection sqlConnection = DBConnection.GetConnection();       
            SqlCommand sqlCommand = new SqlCommand("User_Login",sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
            sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            UserModel userModel = new UserModel();
            while (sqlDataReader.Read())
            {
                userModel.UserName = sqlDataReader["UserName"].ToString();
                userModel.Id = sqlDataReader["Id"].ToString();
            }
            sqlConnection.Close();
            return userModel;
        }
        public bool SaveUser(UserModel userModel)
        {
            try
            {
                SqlConnection sqlConnection = DBConnection.GetConnection();
                string sql = $"insert into [User](Id,UserName,Email,Password,CreatedDate,IsDelete) values('{userModel.Id}','{userModel.UserName}','{userModel.Email}','{userModel.Password}','{userModel.CreatedDate}','{userModel.IsDelete}');";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
               int result= sqlCommand.ExecuteNonQuery();
                if(result>0) return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public bool DeleteUserById(string userId)
        {
            try
            {
                SqlConnection sqlConnection = DBConnection.GetConnection();
                string sql = $"delete from [User] where Id='{userId}' ";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0) return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public bool UpdateUser(UserModel userModel)
        {
            try
            {
                SqlConnection sqlConnection = DBConnection.GetConnection();
                string sql = $"update [User] SET UserName='{userModel.UserName}', Email='{userModel.Email}',Password='{userModel.Password}',UpdatedDate='{DateTime.Now}' where Id='{userModel.Id}'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0) return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
