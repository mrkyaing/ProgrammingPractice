using POS.BusinessLogic;
using POS.Models.Models;
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
    public partial class ProductUI : Form
    {

        ProductController productController;
        public ProductUI()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
            LoadUMList();
        }

        private void LoadUMList()
        {
           
            UMController uMController = new UMController();
            comboUM.DataSource = uMController.getUMList();         
            comboUM.ValueMember = "Id";
            comboUM.DisplayMember = "Description";
            comboUM.SelectedIndex = -1;
            comboUM.SelectedText = "--select one--";
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProductModel productModel = new ProductModel();
                BindProductModel(productModel);
                if (productController.SaveProduct(productModel))
                    MessageBox.Show("Save successed");
                else MessageBox.Show("Save failed");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occurs when saving data.");
            }
        }

        private void BindProductModel(ProductModel productModel)
        {
            productModel.Id = Guid.NewGuid().ToString();
            productModel.Code=txtCode.Text;
            productModel.Description=txtDescription.Text;
            productModel.SellingPrice=Convert.ToDecimal(txtSellingPrice.Text);
            productModel.BuyingPrice=Convert.ToDecimal(txtBuyingPrice.Text);
            productModel.IsInStock =chkIsInStock.Checked;
            productModel.UMID = comboUM.SelectedValue.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCode.Text = txtDescription.Text = txtSellingPrice.Text = txtBuyingPrice.Text = String.Empty;
            comboUM.SelectedIndex = -1;
            chkIsInStock.Checked = false;
        }
    }
}
