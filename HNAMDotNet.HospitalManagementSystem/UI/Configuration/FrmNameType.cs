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

namespace HNAMDotNet.HospitalManagementSystem.UI.Configuration
{
    public partial class FrmNameType : Form
    {
        int _Id = 0;
        public FrmNameType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageEntity message = new MessageEntity();
                if (string.IsNullOrEmpty(txtNameType.Text))
                {
                    MessageBox.Show("Please,Fill Name Type");

                    txtNameType.Select();
                    return;
                }
                if (_Id == 0)
                {
                    message = new NameTypeDao().Save(new Entity.NameTypeEntity()
                    {
                        Type = txtNameType.Text,
                    });
                }
                else
                {
                    message = new NameTypeDao().Update(new Entity.NameTypeEntity()
                    {
                        Type = txtNameType.Text,
                        Id = _Id
                    });
                }

                if (message != null)
                {
                    if (message.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        MessageBox.Show(message.RespDesc);
                        BindDataGridView();
                        txtNameType.Clear();
                        btnSave.Text = "Save";
                        _Id = 0;
                    }
                    else
                    {
                        MessageBox.Show(message.RespDesc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNameType_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        public void BindDataGridView()
        {
            try
            {
                ResNameType resNameType = new NameTypeDao().GetAllNameTypeData();
                if (resNameType != null)
                {
                    dgvNameType.DataSource = resNameType.lstNameType;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNameType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvNameType.SelectedRows[0];
                txtNameType.Text = dgvRow.Cells["colType"].Value.ToString();
                _Id = Convert.ToInt32(dgvRow.Cells["colId"].Value.ToString());
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNameType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNameType.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                      "Confirm Delete!!",
                                      MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageEntity message = new NameTypeDao().Delete(new NameTypeEntity()
                        {
                            Id = Convert.ToInt32(dgvNameType.Rows[e.RowIndex].Cells["colId"].Value)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void ClearAllData()
        {
            txtNameType.Clear();
            _Id = 0;
            btnSave.Text = "Save";
        }
        //private void dgvNameType_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
