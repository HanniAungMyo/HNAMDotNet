using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
    public class ResRoleEntity
    {
        public MessageEntity Message { get; set; }
        public List<RoleEntity> Rows { get; set; }
    }
}
