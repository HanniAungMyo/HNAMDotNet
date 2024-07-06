using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class Speciality
    {
     public int Id { get; set; }   
        public string Name { get; set; }
    }

    public class ResSpeciality
    {
        public MessageEntity messageEntity { get; set; }
        public List<Speciality> lstSpecial { get; set; }
    }
}
