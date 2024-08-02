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

namespace HNAMDotNet.HospitalManagementSystem.UI
{
    public partial class FrmUser : Form
    {
        int _Id = 0;
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            dgvUser.AutoGenerateColumns = false;
            GetComboData();
            BindDataGridView();
        }

        private void GetComboData()
        {
            ResUser resUser = new FrmUserDao().GetComboData();
            try
            {
                if (resUser != null)
                {
                    cboRoleName.DataSource = null;
                    cboRoleName.DataSource = resUser.RoleEntities;
                    cboRoleName.DisplayMember = "RoleName";
                    cboRoleName.ValueMember = "Id";
                    cboRoleName.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDataGridView()
        {
            try
            {
                dgvUser.DataSource = null;
                ResUser resUser = new FrmUserDao().GetAllUserData();
                if (resUser != null)
                {
                    dgvUser.DataSource = resUser.lstUser;
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
                if (CheckRequireFields())
                {
                    if (_Id == 0)
                    {
                        message = new FrmUserDao().Save(new UserEntity()
                        {
                            UserName = txtUser.Text,
                            LoginName = txtLogin.Text,
                            Password = txtPassword.Text,
                            RoleId = Convert.ToInt32(cboRoleName.SelectedValue),
                        });
                    }
                    else
                    {
                        message = new FrmUserDao().Update(new UserEntity()
                        {
                            Id = _Id,
                            UserName = txtUser.Text,
                            LoginName = txtLogin.Text,
                            Password =txtPassword.Text,
                            RoleId =Convert.ToInt32(cboRoleName.SelectedValue),
                        });
                    }
                    if (message.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        MessageBox.Show(message.RespDesc);
                        BindDataGridView();
                        ClearAll(); 
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

        public bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Please, Fill User Name");
                txtUser.Select();
                return false;
            }
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Please, Fill LoginName");
                txtLogin.Select();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please, Fill Password");
                txtPassword.Select();
                return false;
            }
            if (string.IsNullOrEmpty(cboRoleName.Text) || cboRoleName.Text == "__Select One__")
            {
                MessageBox.Show("Select RoleName");
                cboRoleName.DroppedDown = true;
                return false;
            }
            return true;
        }

        public void ClearAll()
        {
            txtUser.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            cboRoleName.SelectedIndex = 0;
            _Id=0;
            btnSave.Text = "Save";
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvUser.SelectedRows[0];
                txtUser.Text = dgvRow.Cells["colUserName"].Value.ToString();
                txtLogin.Text = dgvRow.Cells["colLoginName"].Value.ToString();
                txtPassword.Text = dgvRow.Cells["colPassword"].Value.ToString();
                cboRoleName.SelectedValue = Convert.ToInt32(dgvRow.Cells["colRoleId"].Value);
                _Id = Convert.ToInt32(dgvRow.Cells["colId"].Value);
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUser.Rows[e.RowIndex].Cells["colDel"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageEntity message = new FrmUserDao().Delete(new Entity.UserEntity()
                        {
                            Id = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["colId"].Value)
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
            ClearAll();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboRoleName.Select();
            }
        }

        private void cboRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
