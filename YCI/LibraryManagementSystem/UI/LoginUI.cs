using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text =txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username=txtUserName.Text;
            string userpassword=txtPassword.Text;

            //create the Object of User Service Class of DAO 
            UserService userservice = new UserService();
            
            UserModel usermodel= userservice.GetUserListByUserNameAndPassword(username, userpassword);

            //if user name of UserModel Object is IsNullOrEmpty,then user invalid (user does not exists in DB) 
            if (string.IsNullOrEmpty(usermodel.UserName))
            {
                MessageBox.Show("Invalid User!");
            }
            //User exists in database ,then go to Dashboard (Home Page)
            else
            {
                //hide current Form (LoginUI)
                this.Hide();
                DashboardUI dashboardUI = new DashboardUI();
                dashboardUI.Show();              
            }
        }

        private void LoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
