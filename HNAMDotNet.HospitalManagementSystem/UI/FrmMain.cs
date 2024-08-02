using HNAMDotNet.HospitalManagementSystem.DAO;
using HNAMDotNet.HospitalManagementSystem.Entity;
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
        bool sideBarExpand;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CreateMenu();

        }

        private void CreateMenu()
        {
            try
            {
                ResMenuEntity res = new MenuDao().GetAllMenuByRoleId();
                if (res != null && res.lstMenu.Count>0) 
                { 

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnMenuIcon_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void btnNameType_Click_1(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
