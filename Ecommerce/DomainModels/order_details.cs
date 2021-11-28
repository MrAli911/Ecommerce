using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class order_details
    {
        public int id { get; set; }
        public decimal total { get; set; }
        public DateTime create_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;


        public ICollection<order_items> order_Items { get; set; }

        public User User { get; set; }
        public int UserID { get; set; }

        public payment_details payment_Details { get; set; }
        public int payment_detailsID { get; set; }

    }
}
