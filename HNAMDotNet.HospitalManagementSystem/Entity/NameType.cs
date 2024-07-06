using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class NameType
    {
        public int Id { get; set; }

        public string Type { get; set; }
    }

    public class ResNameType
    {
        public MessageEntity messageEntity { get; set; }
        public List<NameType> lstNameType { get; set; }
    }
}
