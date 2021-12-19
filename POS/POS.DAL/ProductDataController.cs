using POS.Models.ModelCollections;
using POS.Models.Models;
using POS.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    public class ProductDataController
    {
        public ProductModelCollections GetProductList()
        {
            var products = new ProductModelCollections();
            SqlConnection sqlConnection = DBConnection.GetConnection();
            string query = "select Product.*,Um.Description as UMDescription from product " +
                            "inner join UM on Product.UMID = UM.Id where product.isdelete = 0";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ProductModel product = new ProductModel()
                {
                    Id = sqlDataReader["Id"].ToString(),
                    Code = sqlDataReader["Code"].ToString(),
                    UMID = sqlDataReader["UMDescription"].ToString(),
                    Description = sqlDataReader["Description"].ToString(),
                    BuyingPrice =Convert.ToDecimal(sqlDataReader["BuyingPrice"]),
                    SellingPrice = Convert.ToDecimal(sqlDataReader["SellingPrice"]),
                    IsInStock = Convert.ToBoolean(sqlDataReader["IsInStock"]),
                    CreatedUserId = sqlDataReader["CreatedUserId"].ToString(),
                    CreatedDate = Convert.ToDateTime(sqlDataReader["CreatedDate"]),
                };
                if (!(sqlDataReader["UpdatedDate"] is DBNull))
                {
                    product.UpdatedDate = Convert.ToDateTime(sqlDataReader["UpdatedDate"]);
                }
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }

        public void SaveProduct(ProductModel productModel)
        {
            try
            {
                SqlConnection sqlConnection = DBConnection.GetConnection();
                SqlCommand sqlCommand = new SqlCommand("Product_Insert", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Char).Value = productModel.Id;
                sqlCommand.Parameters.Add("@Code", SqlDbType.Char).Value = productModel.Code;
                sqlCommand.Parameters.Add("@Description", SqlDbType.Char).Value = productModel.Description;
                sqlCommand.Parameters.Add("@SellingPrice", SqlDbType.Decimal).Value = productModel.SellingPrice;
                sqlCommand.Parameters.Add("@BuyingPrice", SqlDbType.Decimal).Value = productModel.BuyingPrice;
                sqlCommand.Parameters.Add("@IsInStock", SqlDbType.Bit).Value = productModel.IsInStock;
                sqlCommand.Parameters.Add("@UMID", SqlDbType.Char).Value = productModel.UMID;
                sqlCommand.Parameters.Add("@CreatedUserId", SqlDbType.Char).Value = AuditUser.UserId;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = productModel.CreatedDate;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
