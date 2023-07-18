using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class Discount
    {
        public int ID { get; set; }
        public string DiscountCode { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Final_Date { get; set; }
        public int DiscountCount { get; set; }
    }
}
