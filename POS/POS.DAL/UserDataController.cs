using POS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
