using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SpecialityId { get; set; }

        public int DoctorFees { get; set; }
    }

    public class ResDoctor
    {
        public MessageEntity messageEntity { get; set; }
        public List<Doctor> lstDoctor { get; set; }

    }
}
