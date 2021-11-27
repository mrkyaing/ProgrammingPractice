﻿using POS.BusinessLogic;
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
    public partial class UserListUI : Form
    {
        UserController userController;
        public UserListUI()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void UserListUI_Load(object sender, EventArgs e)
        {
            UserDataGridView.DataSource = userController.GetUserList();
        }
    }
}
