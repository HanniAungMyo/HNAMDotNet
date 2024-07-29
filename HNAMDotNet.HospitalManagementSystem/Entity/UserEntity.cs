using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class UserEntity
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }

    public class ResUser
    {
        public MessageEntity messageEntity { get; set; }
        public UserEntity User { get; set; }
        public List <RoleEntity> RoleEntities { get; set; }
        public List<UserEntity> lstUser { get; set; }
    }
}
