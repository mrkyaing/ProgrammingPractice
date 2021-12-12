using POS.BusinessLogic;
using POS.Models;
using POS.Utilities;
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
        public bool IsUpdateStatus { get; set; }
        public UMUI()
        {
            InitializeComponent();
            uMController=new UMController();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UMModel umModel = new UMModel()
            {              
                Code =txtCode.Text,
                Description = txtDescription.Text
            };
            try
            {
                if (btnSave.Text.Equals("Update"))
                {
                    umModel.Id = AuditUser.Id;
                    if (uMController.UpdateUM(umModel))
                    {
                        MessageBox.Show("update successed");
                    }
                    else
                    {
                        MessageBox.Show("update failed");
                    }
                }
                else
                {
                    umModel.Id = Guid.NewGuid().ToString();
                    if (uMController.SaveUM(umModel))
                    {
                        MessageBox.Show("save successed");
                    }
                    else
                    {
                        MessageBox.Show("save failed");
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void UMUI_Load(object sender, EventArgs e)
        {
            if (IsUpdateStatus)
            {
                btnSave.Text = "Update";
                UMModel umModel = uMController.GetUMById(AuditUser.Id);
                txtCode.Text = umModel.Code;
                txtDescription.Text = umModel.Description;
            }
        }
    }
}
