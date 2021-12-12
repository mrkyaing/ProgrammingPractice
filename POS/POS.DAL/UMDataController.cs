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
        public UMModel GetUMById(string Id)
        {         
            SqlConnection sqlConnection = DBConnection.GetConnection();
            SqlCommand sqlCommand = new SqlCommand("UM_SelectById", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Id",SqlDbType.Char).Value = Id;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            UMModel um = new UMModel();
            while (sqlDataReader.Read())
            {
                um.Id = sqlDataReader["Id"].ToString();
                um.Code = sqlDataReader["Code"].ToString();
                um.Description = sqlDataReader["Description"].ToString();                      
            }
            sqlConnection.Close();
            return um;
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

        public void DeleteUserById(string Id)
        {
            try
            {
                SqlConnection sqlConnection = DBConnection.GetConnection();              
                SqlCommand sqlCommand = new SqlCommand("UM_DeleteById", sqlConnection);
                sqlCommand.CommandType=CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Char).Value = Id;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        public void UpdateUM(UMModel uMModel)
        {
            try
            {
                SqlConnection sqlConnection = DBConnection.GetConnection();
                SqlCommand sqlCommand = new SqlCommand("UM_Update", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Char).Value = uMModel.Id;
                sqlCommand.Parameters.Add("@Code", SqlDbType.Char).Value = uMModel.Code;
                sqlCommand.Parameters.Add("@Description", SqlDbType.Char).Value = uMModel.Description;
                sqlCommand.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value =DateTime.Now;
                sqlCommand.Parameters.Add("@UpdatedUserId", SqlDbType.Char).Value =AuditUser.UserId;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
    }
}
