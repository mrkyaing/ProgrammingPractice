using POS.BusinessLogic;
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
    public partial class UMListUI : Form
    {
        UMController uMController;
        public UMListUI()
        {
            InitializeComponent();
            uMController = new UMController();
        }

        private void UMListUI_Load(object sender, EventArgs e)
        {
            LoadUMList();
        }

        private void LoadUMList()
        {
            this.umGridview.AutoGenerateColumns = false;
            this.umGridview.DataSource = uMController.getUMList();
            this.umGridview.Refresh();
        }

        private void umGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //for edit cell click action 
                if (e.ColumnIndex == 5)
                {
                    UMUI uMUI = new UMUI();
                    AuditUser.Id = umGridview.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    uMUI.IsUpdateStatus = true;
                    uMUI.Show();
                }
                //for delete cell click action 
                else if (e.ColumnIndex == 6)
                {
                    AuditUser.Id = umGridview.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    DialogResult dialogResult=MessageBox.Show("are you sure to delete?","delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (uMController.DeleteUMById(AuditUser.Id))
                        {
                            MessageBox.Show("delete success !!");
                            LoadUMList();
                        }
                    }
                }
            }
        }
    }
}
