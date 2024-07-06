using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNAMDotNet.WindowForm
{
    public partial class FrmCalculatorNew : Form
    {
        string operation = string.Empty;
        int firstNumber = 0;
        public FrmCalculatorNew()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            txtData.Clear();
            txtResult.Clear();
        }

        private void OnClick(object sender, EventArgs e)
        {
            try
            {
                Button btn = (sender) as Button;
                if (IsOperator(btn.Text))
                {
                    string str = txtData.Text.Substring(txtData.Text.Length - 1);
                    if ((txtData.Text.Length == 0) || IsOperator(str)) return;
                }
                txtData.Text += btn.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsOperator(string character)
        {
            return character == "+" || character == "-" || character == "*" || character == "/" || character == "%";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtData.Text))
            {
                string Result = txtData.Text.Substring(0, txtData.Text.Length - 1);
                txtData.Text = Result;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string data = txtData.Text;
                if (IsValidExpression(data))
                {
                    var result = new DataTable().Compute(data, string.Empty);
                    txtResult.Text = result.ToString();
                }
                else{
                    MessageBox.Show("Invalid Expression: Division by zero is not allowed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidExpression(string data)
        {
            // Regex to match division by zero
            string pattern = @"/\s*0(\D|$)";

            // Check if the expression matches the pattern
            return !Regex.IsMatch(data, pattern);
        }
    }
}
