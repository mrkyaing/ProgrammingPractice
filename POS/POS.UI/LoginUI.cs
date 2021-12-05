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
                Password =txtPassword.Text,
            };
            UserModel dbuser=userController.LoginUser(user);
            if (string.IsNullOrEmpty(dbuser.UserName))
            {
                MessageBox.Show("Invalid User");
               
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
    }
}
