using POS.BusinessLogic;
using POS.Models;
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
    public partial class UMUI : Form
    {
        UMController uMController;
        public UMUI()
        {
            InitializeComponent();
            uMController=new UMController();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UMModel umModel = new UMModel()
            {
                Id = Guid.NewGuid().ToString(),
                Code =txtCode.Text,
                Description = txtDescription.Text
            };
            try
            {
                if (uMController.SaveUM(umModel))
                {
                    MessageBox.Show("save successed");
                }
                else
                {
                    MessageBox.Show("save failed");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
