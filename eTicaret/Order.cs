using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret
{
    public class Order
    {

        public string OrderName { get; set; }
        public List<Product> Products{ get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime orderDate { get; set; }

        public string TrackingNumber { get; set; }
        public Customer Customer { get; set; }

        public Shipper Shipper { get; set; }


    }
}
