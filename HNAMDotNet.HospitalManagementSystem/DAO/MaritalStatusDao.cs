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

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class MaritalStatusDao
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public MessageEntity Save(MaritalStatusEntity maritalStatusEntity)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_SaveMaritalStatus, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", maritalStatusEntity.Name);
                cmd.ExecuteNonQuery();
                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Save Successful";
                message.RespType = CommonResponseMessage.ResSuccessType;
                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }

        public ResMaritalStatus GetAllMaritalStatusData()
        {
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllMaritalStatus, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<MaritalStatusEntity> lst = new List<MaritalStatusEntity>();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        lst.Add(new MaritalStatusEntity()
                        {
                            RowNumber = dr["RowNumber"].ToString(),
                            Id = Convert.ToInt32(dr["Id"].ToString()),
                            Name = dr["Name"].ToString()
                        });
                    }

                }
                return new ResMaritalStatus()
                {
                    lstMarital = lst
                };
            }
            catch (Exception ex)
            {
                return new ResMaritalStatus()
                {
                    lstMarital = null
                };
            }
        }

        public MessageEntity Delete(MaritalStatusEntity maritalStatusEntity)
        {
            MessageEntity message = new MessageEntity();

            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_DeleteMaritalStatus, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", maritalStatusEntity.Id);
                cmd.ExecuteNonQuery();
                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Delete Successful";
                message.RespType = CommonResponseMessage.ResSuccessType;
                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }

        public MessageEntity Update(MaritalStatusEntity maritalStatusEntity)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateMaritalStatus, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", maritalStatusEntity.Id);
                cmd.Parameters.AddWithValue("@Name", maritalStatusEntity.Name);
                cmd.ExecuteNonQuery();
                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Update Successful";
                message.RespType = CommonResponseMessage.ResSuccessType;
                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }
    }
}

