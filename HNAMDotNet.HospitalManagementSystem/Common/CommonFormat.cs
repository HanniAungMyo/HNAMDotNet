using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Common
{
    public class CommonFormat
    {
        public static void txtNumberOnly(Guna2TextBox txt, KeyPressEventArgs e)
        {
            if (txt.TextLength == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '0'))
            {
                e.Handled = true;
            }
        }
    }
}
