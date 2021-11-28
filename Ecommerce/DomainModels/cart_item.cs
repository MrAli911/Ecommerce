using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class cart_item
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;

        [Required]
        public shopping_session shopping_session { get; set; }

        public product product { get; set; }
        public int productId { get; set; }

    }

}
