using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_FrameworkCore_Console.Entities
{
    public class Role
    {
        public int roleId { set; get; }
        public string roleName { set; get; }
        public string description { set; get; }
        //reference
        List<UserRole> userRoles { set; get; }
    }
}
