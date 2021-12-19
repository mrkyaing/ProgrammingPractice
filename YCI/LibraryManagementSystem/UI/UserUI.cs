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
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Save failed.");
                    }                  
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
    }
}
