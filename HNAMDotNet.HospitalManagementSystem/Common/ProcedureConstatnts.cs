using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Common
{
    public class ProcedureConstants
    {
        public static string SP_LoginByUserNameAndPassword = "SP_LoginByUserNameAndPassword";
        public static string SP_GetRegistrationComboData = "SP_GetRegistrationComboData";
        public static string SP_SaveRegistration = "SP_SaveRegistration";
        public static string SP_GetAllRegistrationData = "SP_GetAllRegistrationData";
        public static string SP_UpdateRegistration = "SP_UpdateRegistration";
        public static string SP_DeleteRegistration = "SP_DeleteRegistration";
        public static string SP_SaveNameType = "SP_SaveNameType";
        public static string SP_GetAllNameTypeData = "SP_GetAllNameTypeData";
        public static string SP_UpdateNameType = "SP_UpdateNameType";
        public static string SP_DeleteNameType = "SP_DeleteNameType";
        public static string SP_SaveSpeciality = "SP_SaveSpeciality";
        public static string SP_GetAllSpecialityData = "SP_GetAllSpecialityData";
        public static string SP_DeleteSpeciality = "SP_DeleteSpeciality";
        public static string SP_UpdateSpeciality = "SP_UpdateSpeciality";
        public static string SP_SaveMaritalStatus = "SP_SaveMaritalStatus";
        public static string SP_GetAllMaritalStatus = "SP_GetAllMaritalStatus";
        public static string SP_DeleteMaritalStatus = "SP_DeleteMaritalStatus";
        public static string SP_UpdateMaritalStatus = "SP_UpdateMaritalStatus";
        public static string SP_GetDoctorComboData = "SP_GetDoctorComboData";
        public static string SP_SaveDoctor = "SP_SaveDoctor";
        public static string SP_GetAllDoctorData = "SP_GetAllDoctorData";
        public static string SP_DeleteDoctor = "SP_DeleteDoctor";
        public static string SP_UpdateDoctor = "SP_UpdateDoctor";
        public static string SP_SaveBooking = "SP_SaveBooking";
        public static string SP_GetBookingComboData = "SP_GetBookingComboData";
        public static string SP_GetAllBookingData = "SP_GetAllBookingData";
        public static string SP_DeleteBookingData = "SP_DeleteBookingData";
        public static string SP_UpdateBookingData = "SP_UpdateBookingData";
        public static string SP_UpdateBookingStatusById = @"Update Tbl_Booking set Status=@Status,ModifiedBy=@UserId,ModifiedDate=GETDATE() where Id=@Id;";
        public static string SP_GetUserComboData = "SP_GetUserComboData";
        public static string SP_SaveUserForm = "SP_SaveUserForm";
        public static string SP_UpdateUserForm = "SP_UpdateUserForm";
        public static string SP_DeleteUserForm = "SP_DeleteUserForm";
        public static string SP_FrmLoginComboData = "SP_FrmLoginComboData";
        public static string SP_GetAllUserData = "SP_GetAllUserData";
    }

}