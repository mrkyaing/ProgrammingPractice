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
    public partial class DashboardUI : Form
    {
        private int childFormNumber = 0;

        public DashboardUI()
        {
            InitializeComponent();
        }
       
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //result object will get (Yes or No) data 
           DialogResult result= MessageBox.Show("are you sure to loguot?", "Logout",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           //if you choose Yes, will go to Login 
            if(result==DialogResult.Yes)
            {
                this.Hide();
                LoginUI loginUI = new LoginUI();
                loginUI.Show();
            }                      
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserUI userUI=new UserUI();
            //userUI window form is child of MdiParent
            userUI.MdiParent = this;
            userUI.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListUI userListUI=new UserListUI();
            //userListUI window form is child of MdiParent
            userListUI.MdiParent= this;
            userListUI.Show();
        }
    }
}
