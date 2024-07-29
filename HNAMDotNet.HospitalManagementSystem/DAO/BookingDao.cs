using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.Entity;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDevHtmlRenderer.Adapters;
using Microsoft.VisualBasic.ApplicationServices;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class BookingDao
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        MessageEntity message = new MessageEntity();

        public MessageEntity Save(BookingEntity Bke)
        {
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_SaveBooking, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RegistrationId", Bke.RegistrationId);
                cmd.Parameters.AddWithValue("@DoctorId", Bke.DoctorId);
                cmd.Parameters.AddWithValue("@BookingDate", Bke.BookingDate);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);
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

        public ResBookingEntity GetComboData()
        {
            try
            {
                conn = DbConnector.Connect();
                cmd = new SqlCommand(ProcedureConstants.SP_GetBookingComboData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DataTable dtRegistration = new DataTable();
                dtRegistration = ds.Tables[0];
                DataTable dtDoctor = new DataTable();
                dtDoctor = ds.Tables[1];

                List<RegistrationEntity> lstRegistration = new List<RegistrationEntity>();
                lstRegistration.Add(new RegistrationEntity() { Id = 0, Name = "__Select One__" });

                if (dtRegistration != null && dtRegistration.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtRegistration.Rows)
                    {
                        lstRegistration.Add(new RegistrationEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString(),
                        });
                    }
                }

                List<DoctorEntity> lstDoctor = new List<DoctorEntity>();
                lstDoctor.Add(new DoctorEntity() { Id = 0, Name = "__Select One__" });
                if (dtDoctor != null && dtDoctor.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtDoctor.Rows)
                    {
                        lstDoctor.Add(new DoctorEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString(),
                            DoctorFees = Convert.ToInt32(dr["DoctorFees"])
                        });
                    }
                }

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespType = CommonResponseMessage.ResSuccessType;
                return new ResBookingEntity()
                {
                    messageEntity = message,
                    lstRegistration = lstRegistration,
                    lstDoctor = lstDoctor
                };
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespType = CommonResponseMessage.ResErrorType;
                return new ResBookingEntity()
                {
                    messageEntity = message
                };
            }
        }

        public ResBookingEntity GetAllBookingData()
        {
            try
            {
                conn = DbConnector.Connect();
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllBookingData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                List<BookingEntity> lst = new List<BookingEntity>();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        lst.Add(new BookingEntity()
                        {
                            RowNumber = dr["RowNumber"].ToString(),
                            Id = Convert.ToInt32(dr["Id"]),
                            DoctorId = Convert.ToInt32(dr["DoctorId"]),
                            DoctorName = dr["DoctorName"].ToString(),
                            RegistrationId = Convert.ToInt32(dr["RegistrationId"]),
                            RegistrationName = dr["RegistrationName"].ToString(),
                            BookingDate = Convert.ToDateTime(dr["BookingDate"]),
                            Status = dr["Status"].ToString()
                        });
                    }
                }
                return new ResBookingEntity()
                {
                    lstBooking = lst,

                };
            }
            catch (Exception ex)
            {
                return new ResBookingEntity()
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

        public MessageEntity Delete(BookingEntity bke)
        {
            MessageEntity message = new MessageEntity();
            try
            {
                conn = DbConnector.Connect();
                cmd = new SqlCommand(ProcedureConstants.SP_DeleteBookingData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", bke.Id);
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

        public MessageEntity Update(BookingEntity bke)
        {
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateBookingData, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",bke.Id);
                cmd.Parameters.AddWithValue("@RegistrationId", bke.RegistrationId);
                cmd.Parameters.AddWithValue("@DoctorId", bke.DoctorId);
                cmd.Parameters.AddWithValue("@BookingDate", bke.BookingDate);
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);
                cmd.ExecuteNonQuery();

                message.RespCode= CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Update Successful";
                message.RespType= CommonResponseMessage.ResSuccessType;
                return message;
            }
            catch (Exception ex) 
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = "Update Successful";
                message.RespType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }

        public MessageEntity UpdateStatusById(int Id)
        {
            try
            {
                conn = DbConnector.Connect();
                if (conn == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_UpdateBookingStatusById, conn);
                //cmd.CommandType = CommandType.Text; (Optional)
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Status", "Complete");
                cmd.Parameters.AddWithValue("@UserId", CommonFormat.LoginId);
                cmd.ExecuteNonQuery();
                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Update Successful";
                message.RespType = CommonResponseMessage.ResSuccessType;
                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = "Update Successful";
                message.RespType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }


    }
}
