using POS.Models.ModelCollections;
using POS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLogic.Service
{
    public interface IProductService
    {
        ProductModelCollections GetProductList();
        bool SaveProduct(ProductModel proudctModel);
        string SaveProduct(ProductModelCollections productModels);
    }
}
