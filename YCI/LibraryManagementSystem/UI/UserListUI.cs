using LibraryManagementSystem.DAO;
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
    public partial class UserListUI : Form
    {
        public UserListUI()
        {
            InitializeComponent();
        }

        private void UserListUI_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            //getting all of user list from the userserice object and bind to gird view 
            gvUserList.DataSource=userService.GetUserList();
        }
    }
}
