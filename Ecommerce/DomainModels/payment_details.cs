using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class payment_details
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int amonut { get; set; }
        public string provider { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;

    }
}
