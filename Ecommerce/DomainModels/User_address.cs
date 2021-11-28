using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class User_address
    {
        public int Id { get; set; }
        public string address_line1 { get; set; }
        public string address_line2 { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public int telephone { get; set; }
        public int mobile { get; set; }

        [Required]
        public User User { get; set; }
        




    }
}
