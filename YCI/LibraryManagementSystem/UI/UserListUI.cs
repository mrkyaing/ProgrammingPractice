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
        public string selectedId { get; set; }
        private void UserListUI_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void gvUserList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvUserList.Rows[e.RowIndex];
                selectedId = row.Cells["Id"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure to delete?", "Deleting data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UserService userService = new UserService();
                if (userService.DeleteUser(selectedId))
                    MessageBox.Show("delete successed.");
                else MessageBox.Show("delete failed.");
                LoadUserList();
                
            }
        }

        private void LoadUserList()
        {
            UserService userService = new UserService();
            //getting all of user list from the userserice object and bind to gird view 
            gvUserList.DataSource = userService.GetUserList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserUI userUI = new UserUI();
            userUI.selectedId = selectedId;
            userUI.IsUpdatedStatus = true;
            userUI.Show();
        }
    }
}
