using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class discount
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public decimal discount_percent { get; set; }
        public bool active { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;
        public DateTime deleted_at { get; set; } = DateTime.Now;

        [Required]
        public ICollection<product> products { get; set; }
    }
}
