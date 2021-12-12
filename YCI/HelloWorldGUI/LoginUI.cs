using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldGUI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        
            string username=txtUserName.Text;//read the value from the textbox that your input 
            string userpassword=txtPassword.Text;//
         
            if(username.Equals("admin") && userpassword.Equals("admin@123"))
            {
                MessageBox.Show("Hi,Admin welcome !","Login success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User name or password is incorrect ", "Invalid User!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
