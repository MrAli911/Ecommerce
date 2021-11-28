using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class shopping_session
    {
        public int id { get; set; }
        public decimal total { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }


        public ICollection<cart_item> Cart_Items { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }


    }
}
