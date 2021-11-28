using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class product_category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;
        public DateTime deleted_at { get; set; } = DateTime.Now;

        public ICollection<product> products { get; set; }

    }
}
