using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class User : IdentityUser
    {
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int telepone { get; set; }
        public DateTime create_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;

        public ICollection<User_address> User_Addresses { get; set; }
        public ICollection<User_payment> User_Payments { get; set; }



    }
}
