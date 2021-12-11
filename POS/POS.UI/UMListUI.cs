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
            this.umGridview.DataSource=uMController.getUMList();
        }
    }
}
