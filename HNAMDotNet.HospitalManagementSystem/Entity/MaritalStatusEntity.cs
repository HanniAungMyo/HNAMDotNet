using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class MaritalStatusEntity
    {
        public string RowNumber { get; set; }
        public int Id {  get; set; }
        public string Name { get; set; } 
    }

    public class ResMaritalStatus
    {
        public MessageEntity messageEntity { get; set; }
        public List<MaritalStatusEntity> lstMarital { get; set; }
    }
}
