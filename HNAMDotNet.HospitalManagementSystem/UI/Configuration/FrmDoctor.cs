using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.DAO;
using HNAMDotNet.HospitalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HNAMDotNet.HospitalManagementSystem.UI.Configuration
{
    public partial class FrmDoctor : Form
    {
        int _Id = 0;

        public FrmDoctor()
        {
            InitializeComponent();
        }

        public void GetComboData()
        {
            try
            {
                ResDoctor resDoctor = new DoctorDao().GetComboData();
                if (resDoctor != null)
                {
                    if (resDoctor.messageEntity.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        cboSpeciality.DataSource = null;
                        cboSpeciality.DataSource = resDoctor.lstSpeciality;
                        cboSpeciality.DisplayMember = "Name";
                        cboSpeciality.ValueMember = "Id";
                        cboSpeciality.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            dgvDoctor.AutoGenerateColumns = false;
            GetComboData();
            BindDataGridView();
        }

        public void BindDataGridView()
        {
            try
            {
                ResDoctor resDoctor = new DoctorDao().GetAllDoctorData();
                if (resDoctor != null)
                {
                    dgvDoctor.DataSource = resDoctor.lstDoctor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                if (CheckRequiredField())
                {
                    if (_Id == 0)
                    {
                        message = new DoctorDao().Save(new Entity.DoctorEntity()
                        {
                            Name = txtName.Text,
                            SpecialityId = Convert.ToInt32(cboSpeciality.SelectedValue),
                            DoctorFees = Convert.ToInt32(txtDoctorFee.Text),

                        });
                    }
                    else
                    {
                        message = new DoctorDao().Update(new Entity.DoctorEntity()
                        {
                            Id = _Id,
                            Name = txtName.Text,
                            SpecialityId = Convert.ToInt32(cboSpeciality.SelectedValue),
                            DoctorFees = Convert.ToInt32(txtDoctorFee.Text)
                        });
                    }

                    if (message != null)
                    {
                        if (message.RespType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show(message.RespDesc);
                            BindDataGridView();
                            ClearAll();
                            btnSave.Text = "Save";
                            _Id = 0;
                        }
                        else
                        {
                            MessageBox.Show(message.RespDesc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please,Fill Doctor Name");
                txtName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(cboSpeciality.Text) || cboSpeciality.Text == "__Select One__")
            {
                MessageBox.Show("Select Speciality");
                cboSpeciality.DroppedDown = true;
                return false;
            }
            if (string.IsNullOrEmpty(txtDoctorFee.Text))
            {
                MessageBox.Show("Please,Fill Doctor Name");
                txtDoctorFee.Select();
                return false;
            }
            return true;

        }

        private void ClearAll()
        {

            txtName.Clear();
            cboSpeciality.SelectedIndex = 0;
            txtDoctorFee.Clear();
            btnSave.Text = "Save";
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDoctor.Rows[e.RowIndex].Cells["colDel"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageEntity message = new DoctorDao().Delete(new DoctorEntity()
                        {
                            Id = Convert.ToInt32(dgvDoctor.Rows[e.RowIndex].Cells["colId"].Value)
                        });
                        if (message != null)
                        {
                            if (message.RespType == CommonResponseMessage.ResSuccessType)
                            {
                                MessageBox.Show(message.RespDesc);
                                BindDataGridView();
                            }
                            else
                            {
                                MessageBox.Show(message.RespDesc);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDoctor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvDoctor.SelectedRows[0];
                txtName.Text = dgvRow.Cells["colName"].Value.ToString();
                cboSpeciality.SelectedValue = Convert.ToInt32(dgvRow.Cells["colSpecialityId"].Value);
                txtDoctorFee.Text = dgvRow.Cells["colDoctorFee"].Value.ToString();
                _Id = Convert.ToInt32(dgvRow.Cells["colId"].Value.ToString());
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDoctorFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFormat.txtNumberOnly(txtDoctorFee, e);
        }
    }
}