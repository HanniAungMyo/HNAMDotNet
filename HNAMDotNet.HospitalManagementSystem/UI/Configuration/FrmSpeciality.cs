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
    public partial class FrmSpeciality : Form
    {
        public FrmSpeciality()
        {
            InitializeComponent();
        }
        int _Id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try

            {
                MessageEntity message = new MessageEntity();
                if (string.IsNullOrEmpty(txtSpeciality.Text))
                {
                    MessageBox.Show("Please, Fill Speciality");
                    txtSpeciality.Select();
                    return;
                }
                if (_Id == 0)
                {
                    message = new SpecialityDao().Save(new Entity.SpecialityEntity()
                    {
                        Name = txtSpeciality.Text,
                    });
                }
                else
                {
                    message = new SpecialityDao().UpDate(new Entity.SpecialityEntity()
                    {
                        Name = txtSpeciality.Text,
                        Id = _Id
                    });
                    btnSave.Text = "Save";
                    txtSpeciality.Clear();
                }

                if (message != null)
                {
                    if (message.RespType == CommonResponseMessage.ResSuccessType)
                    {
                        MessageBox.Show(message.RespDesc);
                        BindDataGridView();
                        txtSpeciality.Clear();
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
        private void FrmSpeciality_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            try
            {
                ResSpeciality resSpeciality = new SpecialityDao().GetAllDataSpeciality();
                if (resSpeciality != null)
                {
                    dgvSpeciality.DataSource = resSpeciality.lstSpecial;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dgvSpeciality_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvSpeciality.SelectedRows[0];
                txtSpeciality.Text = dgvRow.Cells["colSpeciality"].Value.ToString();
                _Id = Convert.ToInt32(dgvRow.Cells["colId"].Value.ToString());
                btnSave.Text = "Update";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvSpeciality_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSpeciality.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                          "Confirm Delete!!",
                                          MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageEntity message = new SpecialityDao().Delete(new Entity.SpecialityEntity()
                        {
                            Id = Convert.ToInt32(dgvSpeciality.Rows[e.RowIndex].Cells["colId"].Value)
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


    }
}

