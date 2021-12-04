﻿using POS.BusinessLogic;
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
        UserController userController;
        public UserUI()
        {
            InitializeComponent();
            userController= new UserController();
        }
        public string UserId { get; set; }
        public bool IsUpdateStatus { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DBController dbController = new DBController();
            SQLModel sqlModel = dbController.GetDBConnection();
            lblServer.Text = sqlModel.DataSourceName;
            lblDB.Text = sqlModel.DatabaseName;
            lblConn.Text = sqlModel.ConnectionStatus;
            lblState.Text = sqlModel.ConnectionState;
            lbltime.Text = sqlModel.ConnectionTimeOut.ToString();                    
            SaveAction();           
        }

        private void SaveAction()
        {
            UserModel userModel = new UserModel()
            {
                UserName = txtUserName.Text,
                Password = txtPasswrod.Text,
                Email = txtEmail.Text
            };
            if (btnSave.Text == "Update")
            {
                userModel.Id = UserId;
                if (userController.CheckUserAlreadyExists(userModel))
                {
                    MessageBox.Show("Email already exists!");
                    return;
                }
                if (userController.UpdateUser(userModel))
                    MessageBox.Show("Update successed");
                else
                    MessageBox.Show("Update failed");
            }
            else
            {
                if (userController.CheckUserAlreadyExists(userModel))
                {
                    MessageBox.Show("Email already exists!");
                }
                else if (userController.SaveUser(userModel))
                    MessageBox.Show("save successed");
                else
                    MessageBox.Show("save failed");
            }
        }

        private void UserUI_Load(object sender, EventArgs e)
        {
            if (IsUpdateStatus)
            {
                btnSave.Text = "Update";
                UserModel userModel=userController.GetUserListById(UserId);
                txtUserName.Text = userModel.UserName;
                txtPasswrod.Text = userModel.Password;
                txtEmail.Text = userModel.Email;
            }
        }
    }
}
