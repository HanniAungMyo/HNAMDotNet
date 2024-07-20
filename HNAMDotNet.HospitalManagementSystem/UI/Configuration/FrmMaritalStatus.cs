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

    public partial class FrmMaritalStatus : Form

    {
        public FrmMaritalStatus()
        {
            InitializeComponent();
        }
        int _Id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageEntity message = new MessageEntity();

                if (string.IsNullOrEmpty(txtMaritalStatus.Text))
                {
                    MessageBox.Show("Please, Fill MaritalStatus");
                    txtMaritalStatus.Select();
                    return;
                }
                if (_Id == 0)
                {
                    message = new MaritalStatusDao().Save(new Entity.MaritalStatusEntity()
                    {
                        Name = txtMaritalStatus.Text,
                    });
                }
                else
                {
                    message = new MaritalStatusDao().Update(new Entity.MaritalStatusEntity()
                    {
                        Name = txtMaritalStatus.Text,
                        Id = _Id
                    });

                }
                if (message != null)
                {
                    if (message.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        MessageBox.Show(message.RespDesc);
                        BindDataGridView();
                        txtMaritalStatus.Clear();
                        btnSave.Text = "Save";
                        _Id = 0;
                    }
                    else
                    {
                        MessageBox.Show(message.RespDesc);
                    }
                    //message = new MaritalStatusDao().Save(new Entity.MaritalStatusEntity()
                    //{
                    //    Name = txtMaritalStatus.Text
                    //});

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmMaritalStatus_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }
        public void BindDataGridView()
        {
            try
            {
                ResMaritalStatus resMaritalStatus = new MaritalStatusDao().GetAllMaritalStatusData();
                if (resMaritalStatus != null)
                {
                    dgvMaritalStatus.DataSource = resMaritalStatus.lstMarital;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvMaritalStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMaritalStatus.Rows[e.RowIndex].Cells["colDel"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                                         "Confirm Delete!!",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageEntity message = new MaritalStatusDao().Delete(new Entity.MaritalStatusEntity()
                        {
                            Id = Convert.ToInt32(dgvMaritalStatus.Rows[e.RowIndex].Cells["colId"].Value),
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

        private void dgvMaritalStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvMaritalStatus.SelectedRows[0];
                txtMaritalStatus.Text = dgvRow.Cells["colMaritalStatus"].Value.ToString();
                _Id = Convert.ToInt32(dgvRow.Cells["colId"].Value.ToString());
                btnSave.Text = "Update";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}