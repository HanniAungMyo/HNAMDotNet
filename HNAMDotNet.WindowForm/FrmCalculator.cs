using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNAMDotNet.WindowForm
{
    public partial class FrmCalculator : Form
    {
        string operation = string.Empty;
        int firstNumber = 0;
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num1 = btn1.Text;
            txtData.Text = Result + num1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num2 = btn2.Text;
            txtData.Text = Result + num2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num3 = btn3.Text;
            txtData.Text = Result + num3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num4 = btn4.Text;
            txtData.Text = Result + num4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num5 = btn5.Text;
            txtData.Text = Result + num5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num6 = btn6.Text;
            txtData.Text = Result + num6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num7 = btn7.Text;
            txtData.Text = Result + num7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num8 = btn8.Text;
            txtData.Text = Result + num8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string num9 = btn9.Text;
            txtData.Text = Result + num9;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string Result = txtData.Text;
            string plus = btnPlus.Text;
            txtData.Text = Result + plus;
            operation = "+";

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int Result = 0;
            switch (operation)
            {
                case "+":
                    string[] strNumber = txtData.Text.Split('+');
                    foreach (string str in strNumber)
                    {
                        Result += Convert.ToInt32(str);
                    }
                    txtResult.Text = Result.ToString();
                    break;

            }

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            txtData.Clear();
            txtResult.Clear();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(txtData.Text)) { return; }
            if (!string.IsNullOrEmpty(txtData.Text))
            {
                string Result = txtData.Text.Substring(0, txtData.Text.Length - 1);
                txtData.Text = Result;
            }
        }
    }
}
