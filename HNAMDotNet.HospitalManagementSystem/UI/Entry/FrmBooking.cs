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

namespace HNAMDotNet.HospitalManagementSystem.UI.Configuration
{
    public partial class FrmBooking : Form
    {
        int _Id = 0;
        public FrmBooking()
        {
            InitializeComponent();
        }

        private void FrmBooking_Load(object sender, EventArgs e)
        {
            dtpBookingDate.Value = DateTime.Now;
            GetCombodata();
            dgvBooking.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void GetCombodata()
        {
            try
            {
                ResBookingEntity resBke = new BookingDao().GetComboData();
                if (resBke != null)
                {
                    if (resBke.messageEntity.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        cboRegistration.DataSource = null;
                        cboRegistration.DataSource = resBke.lstRegistration;
                        cboRegistration.DisplayMember = "Name";
                        cboRegistration.ValueMember = "Id";
                        cboRegistration.SelectedIndex = 0;

                        cboDoctor.DataSource = null;
                        cboDoctor.DataSource = resBke.lstDoctor;
                        cboDoctor.DisplayMember = "Name";
                        cboDoctor.ValueMember = "Id";
                        cboDoctor.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindDataGridView()
        {
            try
            {
                ResBookingEntity resBke = new BookingDao().GetAllBookingData();
                if (resBke != null)
                {
                    dgvBooking.DataSource = resBke.lstBooking;
                    for (int i = 0; i < resBke.lstBooking.Count; i++)
                    {
                        var item = resBke.lstBooking[i];
                        dgvBooking.Rows[i].Cells["colStatus"].Value = item.Status;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                if (CheckRequiredField())
                {
                    if (_Id == 0)
                    {
                        message = new BookingDao().Save(new BookingEntity()
                        {
                            RegistrationId = Convert.ToInt32(cboRegistration.SelectedValue),
                            DoctorId = Convert.ToInt32(cboDoctor.SelectedValue),
                            BookingDate = dtpBookingDate.Value,
                        });
                    }
                    else
                    {
                        message = new BookingDao().Update(new BookingEntity()
                        {
                            Id = _Id,
                            RegistrationId = Convert.ToInt32(cboRegistration.SelectedValue),
                            DoctorId = Convert.ToInt32(cboDoctor.SelectedValue),
                            BookingDate = dtpBookingDate.Value,
                        });
                    }
                    if (message != null)
                    {
                        if (message.RespType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show(message.RespDesc);
                            BindDataGridView();
                            ClearData();
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
            if (string.IsNullOrEmpty(cboRegistration.Text) || cboRegistration.Text == "__Select One__")
            {
                MessageBox.Show("Select PatientName");
                cboRegistration.DroppedDown = true;
                return false;
            }
            if (string.IsNullOrEmpty(cboDoctor.Text) || cboDoctor.Text == "__Select One__")
            {
                MessageBox.Show("Select DoctorName");
                cboDoctor.DroppedDown = true;
                return false;
            }
            return true;
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                if (dgvBooking.Rows[e.RowIndex].Cells["colDel"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageEntity message = new BookingDao().Delete(new BookingEntity()
                        {
                            Id = Convert.ToInt32(dgvBooking.Rows[e.RowIndex].Cells["colId"].Value)
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

                else if (dgvBooking.Rows[e.RowIndex].Cells["colStatus"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure to complete this patient ??",
                                     "Confirm!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageEntity message = new BookingDao().UpdateStatusById(Convert.ToInt32(dgvBooking.Rows[e.RowIndex].Cells["colId"].Value));
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

        private void ClearData()
        {
            cboRegistration.SelectedIndex = 0;
            cboDoctor.SelectedIndex = 0;
            dtpBookingDate.Value = DateTime.Now;
            _Id = 0;
            btnSave.Text = "Save";
        }

        private void dgvBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dgvBooking.SelectedRows[0];
                cboRegistration.SelectedValue = Convert.ToInt32(row.Cells["colRegistrationId"].Value);
                cboDoctor.SelectedValue = Convert.ToInt32(row.Cells["colDoctorId"].Value);
                dtpBookingDate.Value = Convert.ToDateTime(row.Cells["colDateTime"].Value.ToString());
                _Id = Convert.ToInt32(row.Cells["colId"].Value.ToString());
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
