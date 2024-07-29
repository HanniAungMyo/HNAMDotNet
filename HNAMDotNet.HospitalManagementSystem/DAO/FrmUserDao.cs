using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.Entity;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class FrmUserDao
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public ResUser GetComboData()
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                cmd = new SqlCommand(ProcedureConstants.SP_FrmLoginComboData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dtRole = new DataTable();
                adapter.Fill(dtRole);

                List<RoleEntity> lst = new List<RoleEntity>();
                lst.Add(new RoleEntity() { Id = 0, RoleName = "__Select One__" });

                if (dtRole.Rows != null && dtRole.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtRole.Rows)
                    {
                        lst.Add(new RoleEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            RoleName = dr["RoleName"].ToString()
                        });
                    }
                }
                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespType = CommonResponseMessage.ResSuccessType;
                return new ResUser()
                {
                    messageEntity = message,
                    RoleEntities = lst
                };
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespType = CommonResponseMessage.ResErrorType;
                return new ResUser()
                {
                    messageEntity = message,
                };
            }
        }

        public ResUser GetAllUserData()
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllUserData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dtUser = new DataTable();
                adapter.Fill(dtUser);

                List<UserEntity> lst = new List<UserEntity>();
                if (dtUser.Rows != null && dtUser.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtUser.Rows)
                    {
                        lst.Add(new UserEntity()
                        {
                            RowNumber = dr["RowNumber"].ToString(),
                            Id = Convert.ToInt32(dr["Id"]),
                            UserName = dr["UserName"].ToString(),
                            LoginName = dr["LoginName"].ToString(),
                            Password = Cryptography.Decrypt(dr["Password"].ToString()),
                            RoleName = dr["RoleName"].ToString(),
                            RoleId = Convert.ToInt32(dr["RoleId"].ToString())
                        });
                    }
                }
                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespType = CommonResponseMessage.ResSuccessType;
                return new ResUser()
                {
                    messageEntity = message,
                    lstUser = lst
                };
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespType = CommonResponseMessage.ResErrorType;
                return new ResUser()
                {
                    messageEntity = message,
                };
            }
        }

        public MessageEntity Save(UserEntity user)
        {
            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_SaveUserForm, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@LoginName", user.LoginName);
                cmd.Parameters.AddWithValue("@Password", Cryptography.Encrypt(user.Password));
                cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);

                adapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                _messageEntity.RespDesc = "Saving Successfully";
                _messageEntity.RespType = CommonResponseMessage.ResSuccessType;
                return _messageEntity;
            }
            catch (Exception ex)
            {
                _messageEntity.RespCode = CommonResponseMessage.ResErrorCode;
                _messageEntity.RespDesc = ex.Message;
                _messageEntity.RespType = CommonResponseMessage.ResErrorType;
                return _messageEntity;
            }
        }

        public MessageEntity Delete(UserEntity user)
        {
            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_DeleteUserForm, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", user.Id);
                adapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                _messageEntity.RespDesc = "UserForm Delete Successfully";
                _messageEntity.RespType = CommonResponseMessage.ResSuccessType;
                return _messageEntity;
            }
            catch (Exception ex)
            {
                _messageEntity.RespCode = CommonResponseMessage.ResErrorCode;
                _messageEntity.RespDesc = ex.Message;
                _messageEntity.RespType = CommonResponseMessage.ResErrorType;
                return _messageEntity;
            }
        }

        public MessageEntity Update(UserEntity user)
        {
            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateUserForm, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@LoginName", user.UserName);
                cmd.Parameters.AddWithValue("@Password",Cryptography.Encrypt(user.Password));
                cmd.Parameters.AddWithValue("@RoleId",user.RoleId);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);
                adapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                _messageEntity.RespDesc = "Formlogin Update Successfully";
                _messageEntity.RespType = CommonResponseMessage.ResSuccessType;
                return _messageEntity;
            }
            catch (Exception ex)
            {
                _messageEntity.RespCode = CommonResponseMessage.ResErrorCode;
                _messageEntity.RespDesc = ex.Message;
                _messageEntity.RespType = CommonResponseMessage.ResErrorType;
                return _messageEntity;
            }
        }



    }
}
