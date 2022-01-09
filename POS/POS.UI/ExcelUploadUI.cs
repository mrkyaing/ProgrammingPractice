using ClosedXML.Excel;
using POS.BusinessLogic;
using POS.Models.ModelCollections;
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
    public partial class ExcelUploadUI : Form
    {
        ProductController productController;
        UMController umController;
        //Create a new DataTable.
         private DataTable dt;
        public ExcelUploadUI()
        {
            InitializeComponent();
            productController=new ProductController();
            umController=new UMController();
            dt= new DataTable();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            //open file dialog.
            this.openFileDialogForUpload.ShowDialog();
        }
        private void openFileDialogForUpload_FileOk(object sender, CancelEventArgs e)
        {
            //get file name thate you selected 
            string filePath = openFileDialogForUpload.FileName;

            //Open the Excel file using ClosedXML.
            using (XLWorkbook workBook = new XLWorkbook(filePath))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);

                //Loop through the Worksheet rows.
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        //adding the datatable column Headers
                        foreach (IXLCell cell in row.Cells())
                        {
                            //reading header value of current row of cell.
                            //productCode,ProductDescription,SellingPrice,BuyingPrice
                            dt.Columns.Add(cell.Value.ToString());//ProductCode 
                        }
                        firstRow = false;
                    }
                    else
                    {
                        //Add data rows to DataTable.
                        dt.Rows.Add();
                        int i = 0;                      
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();//p002[row][column] ,Dell ,
                            i++;
                        }
                    }
                    //bind data table to grid view 
                    this.gvProductList.DataSource = dt;
                }
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            var products=ConvertDataTableToProductModelCollections(dt);
            var saveActionStatus = productController.SaveProduct(products);
            if (saveActionStatus.Equals("save success"))
            {
                MessageBox.Show($"excel upload {products.Count} record(s) is complete successfully.");
            }
            else
            {
                MessageBox.Show($"upload failed because of {saveActionStatus}");
            }
            //Now you can save product model collections to database here.
        }
        private ProductModelCollections ConvertDataTableToProductModelCollections(DataTable dt)
        {
            var products = new ProductModelCollections();
            foreach (DataRow row in dt.Rows)
            {
                ProductModel productModel = new ProductModel()
                {
                    Id=Guid.NewGuid().ToString(),
                    Code = (row["ProductCode"].ToString()),//p001
                    Description = row["ProductDescription"].ToString(),//dell
                    BuyingPrice = Convert.ToDecimal(row["BuyingPrice"]),//20000
                    SellingPrice = Convert.ToDecimal(row["SellingPrice"]),//50000
                    IsInStock = row["IsInStock"].ToString().Equals("Yes")?true:false,
                };
                string umcode = row["UMCode"].ToString();//103
                //linq query to get umid by um code 
                var umid= umController.getUMList().Where(x => x.Code.Equals(umcode)).SingleOrDefault().Id;
                if (umid != null)
                 productModel.UMID = umid;
                //adding productModel to the product collections object 
                products.Add(productModel);
            }
            return products;
        }
    
    }
}
