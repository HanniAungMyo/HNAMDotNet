using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.DAO;
using HNAMDotNet.HospitalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNAMDotNet.HospitalManagementSystem.UI.Entry
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            dtpDob.Value = DateTime.Now;
            GetCombodata();
            dgvRegistarion.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void BindDataGridView()
        {
            try
            {
                ResRegistration res = new RegistrationDao().GetAllRegistrationData();
                if (res != null && res.lstRegitration.Count > 0)
                {
                    dgvRegistarion.DataSource = res.lstRegitration;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCombodata()
        {
            try
            {
                ResRegistration resRegitration = new RegistrationDao().GetCombodata();
                if (resRegitration != null)
                {
                    if (resRegitration.messageEntity.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        cboNameType.DataSource = null;
                        cboNameType.DataSource = resRegitration.lstNameType;
                        cboNameType.DisplayMember = "Type";
                        cboNameType.ValueMember = "Id";

                        cboMaritalStatus.DataSource = null;
                        cboMaritalStatus.DataSource = resRegitration.lstMaritalStatus;
                        cboMaritalStatus.DisplayMember = "Name";
                        cboMaritalStatus.ValueMember = "Id";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequireFields())
                {
                    //if (rdoMale.Checked)
                    //{
                    //    gender = "Male";
                    //}
                    //else
                    //{
                    //    gender = "Female";
                    //}
                    MessageEntity msgEntity = new RegistrationDao().Save(new Registration()
                    {
                        NameTypeId = Convert.ToInt32(cboNameType.SelectedValue),
                        Name = txtName.Text,
                        Dob = dtpDob.Value,
                        PhoneNo = txtPhNo.Text,
                        FatherName = txtFatherName.Text,
                        Gender = rdoMale.Checked ? "Male" : "Female",
                        MaritalStatusId = Convert.ToInt32(cboMaritalStatus.SelectedValue)
                    });
                    if (msgEntity.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        MessageBox.Show(msgEntity.RespDesc);
                        BindDataGridView();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show(msgEntity.RespDesc);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(cboNameType.Text))
            {
                MessageBox.Show("Select Name Type!");
                cboNameType.DroppedDown = true;
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Fill Name!");
                txtName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(txtPhNo.Text))
            {
                MessageBox.Show("Fill Phone No!");
                txtPhNo.Select();
                return false;
            }
            if (string.IsNullOrEmpty(txtFatherName.Text))
            {
                MessageBox.Show("Fill Father Name!");
                txtFatherName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(cboMaritalStatus.Text))
            {
                MessageBox.Show("Select Marital Status!");
                cboMaritalStatus.DroppedDown = true;
                return false;
            }

            return true;
        }

        private void ClearAll()
        {
            cboNameType.SelectedIndex = 0;
            txtName.Clear();
            dtpDob.Value = DateTime.Now;
            txtFatherName.Clear();
            txtPhNo.Clear();
            rdoFemale.Checked = false;
            rdoMale.Checked = true;
            cboMaritalStatus.SelectedIndex = 0;
        }

        private void dgvRegistarion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow=dgvRegistarion.SelectedRows[0];
            cboNameType.SelectedValue =Convert.ToInt32(dgvRow.Cells["colNameTypeId"].Value);
            txtName.Text= dgvRow.Cells["colName"].Value.ToString();
            dtpDob.Value=Convert.ToDateTime(dgvRow.Cells["colDob"].Value.ToString()) ;
            txtPhNo.Text = dgvRow.Cells["colPhone"].Value.ToString();
            txtFatherName.Text = dgvRow.Cells["colFatherName"].Value.ToString();
            if (dgvRow.Cells["colGender"].Value.ToString() == "Male")
            {
                rdoMale.Checked = true;
                rdoFemale.Checked = false;
            }
            else
            {
                rdoMale.Checked = false;
                rdoFemale.Checked = true;
            }
            cboMaritalStatus.SelectedValue = Convert.ToInt32(dgvRow.Cells["colMaritalStatusId"].Value);
            btnSave.Text = "Update";

        }
    }
}
