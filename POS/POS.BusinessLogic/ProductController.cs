using POS.BusinessLogic.Service;
using POS.DAL;
using POS.Models.ModelCollections;
using POS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLogic
{
    public class ProductController : IProductService
    {
        ProductDataController productDataController;
        public ProductController()
        {
            productDataController = new ProductDataController();
        }
        public ProductModelCollections GetProductList()
        {
            return productDataController.GetProductList();
        }

        public bool SaveProduct(ProductModel proudctModel)
        {
            try
            {
                productDataController.SaveProduct(proudctModel);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public string SaveProduct(ProductModelCollections productModels)
        {
            try
            {
                foreach (var productModel in productModels)
                {
                    var productExists = productDataController.GetProductList().Where(x => x.Code.Equals(productModel.Code));
                    if (productExists.Any())
                    {
                        return $"{productExists.FirstOrDefault().Code} prodcut already exists";
                    }
                    else
                    {
                        productDataController.SaveProduct(productModel);
                    }
                }
                return "save success";
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
