using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class Table
    {
        public int ID { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Final_Date { get; set; }
        public string CouponCount { get; set; }
    }
}

