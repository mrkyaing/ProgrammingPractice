using POS.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UI
{
    public partial class ProductListUI : Form
    {
        ProductController productController;
        public ProductListUI()
        {
            InitializeComponent();
            productController= new ProductController();
        }

        private void ProductListUI_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void LoadProductList()
        {
            gvProduct.AutoGenerateColumns = false;
            gvProduct.DataSource=productController.GetProductList();
        }
    }
}
