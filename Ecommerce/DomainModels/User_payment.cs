using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class User_payment
    {
        public int id { get; set; }
        public string payment_type { get; set; }
        public string provider { get; set; }
        public int account_no { get; set; }
        public DateTime expiry { get; set; }

        [Required]
        public User User { get; set; }
        
    }
}
