using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.DAO;
using HNAMDotNet.HospitalManagementSystem.Entity;

namespace HNAMDotNet.HospitalManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUserName.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please, Fill User Name");
                txtUserName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please, Fill Password");
                txtPassword.Select();
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequireFields())
                {
                    ResUser resUser = new UserDao().Login(new User()
                    {
                        UserName = txtUserName.Text.Trim(),
                        Password = txtPassword.Text.Trim()
                    });

                    if (resUser != null)
                    {
                        if (resUser.messageEntity.RespType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show(resUser.messageEntity.RespDesc);
                        }
                        else
                        {
                            MessageBox.Show(resUser.messageEntity.RespDesc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}
