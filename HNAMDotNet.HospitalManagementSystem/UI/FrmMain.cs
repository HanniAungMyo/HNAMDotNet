using HNAMDotNet.HospitalManagementSystem.UI.Configuration;
using HNAMDotNet.HospitalManagementSystem.UI.Entry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNAMDotNet.HospitalManagementSystem.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.Show();
        }

        private void btnNameType_Click(object sender, EventArgs e)
        {
            FrmNameType frm = new FrmNameType();
            frm.Show();
        }

        private void btnMarital_Click(object sender, EventArgs e)
        {
            FrmMaritalStatus frm = new FrmMaritalStatus();
            frm.Show();
        }

        private void btnSpeciality_Click(object sender, EventArgs e)
        {
            FrmSpeciality frm = new FrmSpeciality();
            frm.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            FrmBooking frm = new FrmBooking();
            frm.Show();
        }
    }
}
