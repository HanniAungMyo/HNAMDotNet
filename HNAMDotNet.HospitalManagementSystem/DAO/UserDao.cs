using HNAMDotNet.HospitalManagementSystem.Common;
using Microsoft.Data.SqlClient;
using HNAMDotNet.HospitalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class UserDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;

        public ResUser Login(User user)
        {

            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                User User = new User();
                sqlConnection = DbConnector.Connect();
                if (sqlConnection == null) return null;

                scom = new SqlCommand(ProcedureConstants.SP_LoginByUserNameAndPassword, sqlConnection);
                scom.CommandType = CommandType.StoredProcedure;
                scom.Parameters.AddWithValue("@UserName", user.UserName);
                scom.Parameters.AddWithValue("@Password", user.Password);
                adapter = new SqlDataAdapter(scom);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    User.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
                    User.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                    User.Password = ds.Tables[0].Rows[0]["Password"].ToString();

                    _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                    _messageEntity.RespDesc = "Login Successfully";
                    _messageEntity.RespType = CommonResponseMessage.ResSuccessType;
                }
                else
                {
                    _messageEntity.RespCode = CommonResponseMessage.ResWarningCode;
                    _messageEntity.RespDesc = "Invalid UserName And Password";
                    _messageEntity.RespType = CommonResponseMessage.ResWarningType;
                }

                return new ResUser()
                {
                    messageEntity = _messageEntity,
                    User = User
                };

            }
            catch (Exception ex)
            {
                _messageEntity.RespCode = CommonResponseMessage.ResErrorCode;
                _messageEntity.RespDesc = ex.Message;
                _messageEntity.RespType = CommonResponseMessage.ResErrorType;
                return new ResUser() { messageEntity = _messageEntity };
            }
        }
    }
}
