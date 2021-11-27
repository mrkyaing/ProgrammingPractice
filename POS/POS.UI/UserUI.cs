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
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBController dbController = new DBController();
            SQLModel sqlModel = dbController.GetDBConnection();
            lblServer.Text = sqlModel.DataSourceName;
            lblDB.Text = sqlModel.DatabaseName;
            lblConn.Text = sqlModel.ConnectionStatus;
            lblState.Text = sqlModel.ConnectionState;
            lbltime.Text = sqlModel.ConnectionTimeOut.ToString();

            UserModel userModel = new UserModel()
            {
                UserName = txtUserName.Text,
                Password = txtPasswrod.Text,
                Email = txtEmail.Text
            };
            UserController userController = new UserController();
            if (userController.SaveUser(userModel))
                MessageBox.Show("save successed");
            else
                MessageBox.Show("save failed");
        }
    }
}
