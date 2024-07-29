using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class RegistrationDao
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public ResRegistration GetCombodata()

        {
            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                con = DbConnector.Connect();
                if (con == null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetRegistrationComboData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DataTable dtNameType = new DataTable();
                dtNameType = ds.Tables[0];
                DataTable dtMarital = new DataTable();
                dtMarital = ds.Tables[1];

                List<NameTypeEntity> lstNameType = new List<NameTypeEntity>();
                if (dtNameType != null && dtNameType.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtNameType.Rows)
                    {
                        lstNameType.Add(new NameTypeEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Type = dr["Type"].ToString(),
                        });
                    }
                }
                List<MaritalStatusEntity> lstMaritalStatus = new List<MaritalStatusEntity>();
                if (dtMarital != null && dtMarital.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtMarital.Rows)
                    {
                        lstMaritalStatus.Add(new MaritalStatusEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString(),
                        });
                    }
                }
                _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                _messageEntity.RespType = CommonResponseMessage.ResSuccessType;
                return new ResRegistration()
                {
                    messageEntity = _messageEntity,
                    lstMaritalStatus = lstMaritalStatus,
                    lstNameType = lstNameType,
                };
            }
            catch (Exception ex)
            {
                _messageEntity.RespCode = CommonResponseMessage.ResErrorCode;
                _messageEntity.RespDesc = ex.Message;
                _messageEntity.RespType = CommonResponseMessage.ResErrorType;
                return new ResRegistration()
                {
                    messageEntity = _messageEntity
                };
            }
        }

        public MessageEntity Save(RegistrationEntity reg)
        {
            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                con = DbConnector.Connect();
                if (con == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_SaveRegistration, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", reg.Name);
                cmd.Parameters.AddWithValue("@Dob", reg.Dob);
                cmd.Parameters.AddWithValue("@PhoneNo", reg.PhoneNo);
                cmd.Parameters.AddWithValue("@FatherName", reg.FatherName);
                cmd.Parameters.AddWithValue("@Gender", reg.Gender);
                cmd.Parameters.AddWithValue("@MaritalStatusId", reg.MaritalStatusId);
                cmd.Parameters.AddWithValue("@NameTypeId", reg.NameTypeId);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);

                dataAdapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                _messageEntity.RespDesc = "Registration Successfully";
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

        public ResRegistration GetAllRegistrationData()
        {
            try
            {

                con = DbConnector.Connect();
                if (con == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllRegistrationData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                List<RegistrationEntity> lst = new List<RegistrationEntity>();
                foreach (DataRow dr in dt.Rows) 
                {
                    lst.Add(new RegistrationEntity()
                    {
                        RowNo = dr["RowNo"].ToString(),
                        Id = Convert.ToInt32(dr["Id"]),
                        FullName = dr["FullName"].ToString(),
                        Name = dr["Name"].ToString(),
                        Dob = Convert.ToDateTime(dr["Dob"]),
                        PhoneNo = dr["PhoneNo"].ToString(),
                        FatherName = dr["FatherName"].ToString(),
                        Gender = dr["Gender"].ToString(),
                        MaritalStatusName = dr["MaritalStatus"].ToString(),
                        NameTypeId = Convert.ToInt32(dr["NameTypeId"]),
                        MaritalStatusId = Convert.ToInt32(dr["MaritalStatusId"]),
                    });

                }
                return new ResRegistration()
                {
                    lstRegitration = lst,
                };
            }
            catch (Exception ex)
            {
                return new ResRegistration()
                {
                    messageEntity = new MessageEntity()
                    {
                        RespCode = CommonResponseMessage.ResErrorCode,
                        RespDesc = ex.Message,
                        RespType = CommonResponseMessage.ResErrorType
                    }
                };
            }
        }

        public MessageEntity Update(RegistrationEntity reg)
        {
            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                con = DbConnector.Connect();
                if (con == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateRegistration, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", reg.Id);
                cmd.Parameters.AddWithValue("@Name", reg.Name);
                cmd.Parameters.AddWithValue("@Dob", reg.Dob);
                cmd.Parameters.AddWithValue("@PhoneNo", reg.PhoneNo);
                cmd.Parameters.AddWithValue("@FatherName", reg.FatherName);
                cmd.Parameters.AddWithValue("@Gender", reg.Gender);
                cmd.Parameters.AddWithValue("@MaritalStatusId", reg.MaritalStatusId);
                cmd.Parameters.AddWithValue("@NameTypeId", reg.NameTypeId);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);
                dataAdapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                _messageEntity.RespDesc = "Registration Update Successfully";
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

        public MessageEntity Delete(RegistrationEntity reg)
        {
            MessageEntity _messageEntity = new MessageEntity();
            try
            {
                con = DbConnector.Connect();
                if (con == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_DeleteRegistration, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", reg.Id);
                dataAdapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                _messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                _messageEntity.RespDesc = "Registration Delete Successfully";
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
