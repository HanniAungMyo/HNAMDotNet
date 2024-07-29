using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class BookingEntity
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public string RegistrationName { get; set; }
        public string DoctorName { get; set; }
        public int DoctorId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
    }

    public class ResBookingEntity
    {
        public MessageEntity messageEntity { get; set; }
        public List<BookingEntity> lstBooking { get; set; }
        public List<RegistrationEntity> lstRegistration { get; set; }
        public List<DoctorEntity> lstDoctor { get; set; }
    }
}
