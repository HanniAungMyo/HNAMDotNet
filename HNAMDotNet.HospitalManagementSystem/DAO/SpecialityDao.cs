using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class SpecialityDao
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public MessageEntity Save(SpecialityEntity specialityEntity)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_SaveSpeciality, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", specialityEntity.Name);
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

        public ResSpeciality GetAllDataSpeciality()
        {
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllSpecialityData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<SpecialityEntity> lst = new List<SpecialityEntity>();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        lst.Add(new SpecialityEntity()
                        {
                            RowNumber = Convert.ToInt32(dr["RowNumber"].ToString()),
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString()
                        });
                    }
                }
                return new ResSpeciality()
                {
                    lstSpecial = lst
                };

            }
            catch (Exception ex)
            {
                return new ResSpeciality()
                {
                    lstSpecial = null
                };
            }


        }

        public MessageEntity Delete(SpecialityEntity specialityEntity)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_DeleteSpeciality, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", specialityEntity.Id);
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

        public MessageEntity UpDate(SpecialityEntity specialityEntity) 
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateSpeciality, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", specialityEntity.Id);
                cmd.Parameters.AddWithValue("@Name", specialityEntity.Name);
                cmd.ExecuteNonQuery();
                message.RespType= CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Update Successful";
                message.RespCode=CommonResponseMessage.ResSuccessCode;
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
