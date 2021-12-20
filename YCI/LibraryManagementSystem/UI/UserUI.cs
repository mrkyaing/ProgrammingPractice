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
    public partial class UserUI : Form
    {
        public string selectedId { get; set; }
        public bool IsUpdatedStatus { get; set; }
        public UserUI()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text;
                string confirmpassword = txtConfirmPassword.Text;               
                if (password.Equals(confirmpassword))
                {
                    if (btnSave.Text.Equals("Update")) UpdateAction(password);
                    else SaveAction(password);
                }
                else
                {
                    MessageBox.Show("password and confirm password does not match.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur when saving user data.");
            }
           
        }

        private void UpdateAction(string password)
        {
            UserModel userModel = new UserModel();
            userModel.Id = selectedId;//selected Id(UserId) for updating process .
            userModel.UserName = txtUserName.Text;
            userModel.Email = txtEmail.Text;
            userModel.Passwrod = password;

            if (rdoAdmin.Checked)
            {
                userModel.Role = rdoAdmin.Text;
            }
            else if (rdoStaff.Checked)
            {
                userModel.Role = rdoStaff.Text;
            }

            UserService userservice = new UserService();
            try
            {
                userservice.UpdateUser(userModel);
                MessageBox.Show("Update successed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void SaveAction(string password)
        {
            UserModel userModel = new UserModel();
            userModel.Id = Guid.NewGuid().ToString();//system auto-generate string id (length 36)
            userModel.UserName = txtUserName.Text;
            userModel.Email = txtEmail.Text;
            userModel.Passwrod = password;

            if (rdoAdmin.Checked)
            {
                userModel.Role = rdoAdmin.Text;
            }
            else if (rdoStaff.Checked)
            {
                userModel.Role = rdoStaff.Text;
            }

            UserService userservice = new UserService();
            try
            {
                userservice.SaveUser(userModel);
                MessageBox.Show("Save successed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed.");
            }
        }

        private void UserUI_Load(object sender, EventArgs e)
        {
            if (IsUpdatedStatus)
            {
                btnSave.Text = "Update";
                UserModel userModel = new UserModel();
                UserService userservice = new UserService();
                userModel = userservice.GetUserById(selectedId);
                txtUserName.Text=userModel.UserName;
                txtEmail.Text=userModel.Email;
                txtPassword.Text=userModel.Passwrod;
                txtConfirmPassword.Text = userModel.Passwrod;
                if (userModel.Role.Trim().Equals("Admin"))rdoAdmin.Checked = true;
                else if(userModel.Role.Trim().Equals("Staff"))rdoStaff.Checked = true;
            }
        }
    }
}
