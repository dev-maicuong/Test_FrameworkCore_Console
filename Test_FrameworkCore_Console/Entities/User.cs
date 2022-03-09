using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_FrameworkCore_Console.Entities
{
    public class User
    {
        public long userId { set; get; }
        public string email { set; get; }
        public string pass { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public DateTime? DayCreate { set; get; }
        public DateTime? DayUpdate { set; get; }
        //reference
        public UserDetail userDetail { set; get; }
        public List<UserRole> userRoles { set; get; }
        public List<Product> products { set; get; }
    }
}
