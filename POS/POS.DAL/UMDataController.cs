using POS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Utilities;
using POS.Models.ModelCollections;

namespace POS.DAL
{
    public class UMDataController
    {
        public UMModelCollections GetUMList()
        {
            var uMs=new UMModelCollections();
            SqlConnection sqlConnection = DBConnection.GetConnection();

            SqlCommand sqlCommand=new SqlCommand("UM_SelectAll", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                UMModel um = new UMModel()
                {
                    Id = sqlDataReader["Id"].ToString(),
                    Code = sqlDataReader["Code"].ToString(),
                    Description = sqlDataReader["Description"].ToString(),
                    CreatedUserId = sqlDataReader["CreatedUserId"].ToString(),
                    CreatedDate = Convert.ToDateTime(sqlDataReader["CreatedDate"]),
                };
                if (!(sqlDataReader["UpdatedDate"] is DBNull))
                {
                    um.UpdatedDate = Convert.ToDateTime(sqlDataReader["UpdatedDate"]);
                }
            uMs.Add(um);
            }
            sqlConnection.Close();
            return uMs;
        }

        public bool SaveUM(UMModel umModel)
        {
            try
            {
                SqlConnection sqlConnection = DBConnection.GetConnection();
                
                SqlCommand sqlCommand = new SqlCommand("UM_Insert", sqlConnection);
                sqlCommand.CommandType=CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Id",SqlDbType.Char).Value= umModel.Id;
                sqlCommand.Parameters.Add("@Code", SqlDbType.Char).Value = umModel.Code;
                sqlCommand.Parameters.Add("@Description", SqlDbType.Char).Value = umModel.Description;
                sqlCommand.Parameters.Add("@CreatedUserId", SqlDbType.Char).Value =AuditUser.UserId;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = umModel.CreatedDate;
                sqlCommand.ExecuteNonQuery();
                return true;
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
                string sql = $"update  [User] set IsDelete=1,DeletedUserId='{AuditUser.UserId}' where Id='{userId}' ";
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
