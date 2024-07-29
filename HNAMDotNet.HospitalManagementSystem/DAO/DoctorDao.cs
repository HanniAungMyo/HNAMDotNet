using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.Entity;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections.Specialized;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class DoctorDao
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public ResDoctor GetComboData()
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_GetDoctorComboData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dtSpeciality = new DataTable();

                adapter.Fill(dtSpeciality);
                List<SpecialityEntity> lstSpeciality = new List<SpecialityEntity>();
                lstSpeciality.Add(new SpecialityEntity() { Id = 0, Name = "__Select One__" });
                if (dtSpeciality != null && dtSpeciality.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtSpeciality.Rows)
                    {
                        lstSpeciality.Add(new SpecialityEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString()
                        });
                    }
                }
                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespType = CommonResponseMessage.ResSuccessType;
                return new ResDoctor()
                {
                    messageEntity = message,
                    lstSpeciality = lstSpeciality
                };
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespType = CommonResponseMessage.ResErrorType;
                return new ResDoctor()
                {
                    messageEntity = message
                };
            }
        }

        public MessageEntity Save(DoctorEntity dct)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_SaveDoctor, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", dct.Name);
                cmd.Parameters.AddWithValue("@SpecialityId", dct.SpecialityId);
                cmd.Parameters.AddWithValue("@DoctorFees", dct.DoctorFees);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);
                adapter = new SqlDataAdapter(cmd);
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

        public ResDoctor GetAllDoctorData()
        {
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllDoctorData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                List<DoctorEntity> lst = new List<DoctorEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Add(new DoctorEntity()
                    {
                        RowNumber = dr["RowNumber"].ToString(),
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        SpecialityId = Convert.ToInt32(dr["SpecialityId"]),
                        SpecialityName = dr["SpecialityName"].ToString(),
                        DoctorFees = Convert.ToInt32(dr["DoctorFees"])
                    });
                }
                return new ResDoctor()
                {
                    lstDoctor = lst,
                };
            }

            catch (Exception ex)
            {
                return new ResDoctor()
                {
                    lstDoctor = null
                };
            }
        }

        public MessageEntity Delete(DoctorEntity Dct)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_DeleteDoctor, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Dct.Id);
                adapter = new SqlDataAdapter(cmd);
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

        public MessageEntity Update(DoctorEntity dct)
        {
            MessageEntity message = new MessageEntity();

            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateDoctor, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", dct.Id);
                cmd.Parameters.AddWithValue("@Name", dct.Name);
                cmd.Parameters.AddWithValue("@SpecialityId", dct.SpecialityId);
                cmd.Parameters.AddWithValue("@DoctorFees", dct.DoctorFees);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);
                adapter = new SqlDataAdapter(cmd);
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
