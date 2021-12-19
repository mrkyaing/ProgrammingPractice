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
    public partial class LoginUI : Form
    {
        UserController userController;
        public LoginUI()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel()
            {
                UserName =txtUserName.Text,
                Password =EncryptionUtility.EncryptPlainTextToCipherText( txtPassword.Text, "posadmin@123"),//zip
            };
            UserModel dbuser=userController.LoginUser(user);
         
            if (string.IsNullOrEmpty(dbuser.UserName))
            {
                MessageBox.Show("User Name or Password is incorrect", "Invalid User", MessageBoxButtons.OK,MessageBoxIcon.Information);     
            }
            else
            {
                
               
                    this.Hide();
                    AuditUser.UserId = dbuser.Id;
                    AuditUser.UserName = dbuser.UserName;
                    DashboardUI dashboardUI = new DashboardUI();
                    dashboardUI.Show();
                    
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
                errorProviderUserName.SetError(txtUserName,"fill user name.");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Focus();
                errorProviderUserName.SetError(txtPassword, "fill password.");
            }
        }
    }
}
