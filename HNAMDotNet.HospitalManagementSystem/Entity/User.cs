using HNAMDotNet.HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class ResUser
    {
        public MessageEntity messageEntity { get; set; }    
        public User User {  get; set; }
    }
}
