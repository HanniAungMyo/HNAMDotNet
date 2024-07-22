using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class DoctorEntity
    {
        public string RowNumber {  get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; } 
        public int DoctorFees { get; set; }
    }

    public class ResDoctor
    {
        public MessageEntity messageEntity { get; set; }
        public List<DoctorEntity> lstDoctor { get; set; }
        public List<SpecialityEntity> lstSpeciality { get; set; }

    }
}
