using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_FrameworkCore_Console.Entities
{
    public class Product
    {
        public long productId { set; get; }
        public string productName { set; get; }
        [ForeignKey("userId")]
        public User user { set; get; }
        public long? userId { set; get; }
    }
}
