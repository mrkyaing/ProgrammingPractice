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
    public partial class SimpleCalculatorUI : Form
    {
        public SimpleCalculatorUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 =Convert.ToDouble(txtNum1.Text);
                double n2=Convert.ToDouble(txtNum2.Text);
                double result=n1 + n2;
                txtResult.Text =result.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show("Invalid values try agatin");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNum1.Text);
                double n2 = Convert.ToDouble(txtNum2.Text);
                double result = n1 - n2;
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid values try agatin");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNum1.Text);
                double n2 = Convert.ToDouble(txtNum2.Text);
                double result = n1 * n2;
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid values try agatin");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNum1.Text);
                double n2 = Convert.ToDouble(txtNum2.Text);
                double result = n1 / n2;
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid values try agatin");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtResult.Text = string.Empty;
        }
    }
}
