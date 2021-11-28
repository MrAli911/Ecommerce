using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class product_inventory
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public DateTime created_at  { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;
        public DateTime deleted_at { get; set; } = DateTime.Now;




    }
}
