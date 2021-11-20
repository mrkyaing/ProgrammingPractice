using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnection = DbConnection.GetConnection();
                if (sqlConnection != null)
                {
                    lblStatus.Text = "database connection is connected.";
                    lblStatus.ForeColor = Color.Green;
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lblStatus.Text = "database connection is failed.";
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
