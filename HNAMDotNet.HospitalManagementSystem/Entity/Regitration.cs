using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class Regitration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNo { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public int MaritalStatusId { get; set; }
        public int NameTypeId { get; set; }
    }

    public class ResRegitration
    {
        public MessageEntity messageEntity { get; set; }
        public List<Regitration> lstRegitration { get; set; }
    }

}
