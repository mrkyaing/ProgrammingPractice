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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,Today is super sunday","My App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGoToLoginUI_Click(object sender, EventArgs e)
        {
            //nagivate Form 1 to Login Form when click btnGoToLoginUI 
            LoginUI loginUI=new LoginUI();
            loginUI.Show();
        }

        private void btnGotoSimpleCalcUI_Click(object sender, EventArgs e)
        {
            SimpleCalculatorUI calculatorUI=new SimpleCalculatorUI();
            calculatorUI.Show();//invoke calculator UI
        }
    }
}
