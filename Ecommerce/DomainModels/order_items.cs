using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class order_items
    {
        public int id { get; set; }
        public int qunatity { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;

        [Required]
        public order_details order_Details { get; set; }

        public product product { get; set; }
        public int productId { get; set; }


    }
}
