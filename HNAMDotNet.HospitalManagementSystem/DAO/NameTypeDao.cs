using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.Entity;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class NameTypeDao
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public MessageEntity Save(NameTypeEntity nameType)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_SaveNameType, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", nameType.Type);
                //adapter = new SqlDataAdapter(cmd);
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

        public ResNameType GetAllNameTypeData() 
        {
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllNameTypeData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt=new DataTable();
                adapter.Fill(dt);
                List<NameTypeEntity> lst = new List<NameTypeEntity>();
                if (dt != null && dt.Rows.Count > 0) 
                {
                    foreach (DataRow dr in dt.Rows) 
                    {
                        lst.Add(new NameTypeEntity()
                        {
                            RowNumber = dr["RowNumber"].ToString(),
                            Id =Convert.ToInt32(dr["Id"]),
                            Type = dr["Type"].ToString()
                        });
                    }
                }
                return new ResNameType()
                {
                    lstNameType = lst
                };
            }
            catch (Exception ex) 
            {
                return new ResNameType()
                {
                    lstNameType = null
                };
            }
        }

        public MessageEntity Update(NameTypeEntity nameType)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateNameType, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", nameType.Id);
                cmd.Parameters.AddWithValue("@Type", nameType.Type);
                //adapter = new SqlDataAdapter(cmd);
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

        public MessageEntity Delete(NameTypeEntity nameType)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_DeleteNameType, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", nameType.Id);
                //adapter = new SqlDataAdapter(cmd);
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
    }
}
