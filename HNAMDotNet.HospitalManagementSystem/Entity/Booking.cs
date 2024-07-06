using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class Booking
    {
      public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int DoctorId { get; set; }
        public DateTime BookingDate { get; set; }
    }

    public class ResBooking
    {
        public MessageEntity messageEntity { get; set; }
        public List<Booking> lstBooking { get; set; }
    }
}
