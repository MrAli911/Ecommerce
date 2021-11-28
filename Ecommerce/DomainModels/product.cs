using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description {  get; set; }
        public decimal price  { get; set; }
        public DateTime create_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;
        public string SKU { get; set; }
        public DateTime delete_at { get; set; } = DateTime.Now;
        public byte[] image { get; set; }
        [Required]
        public discount discount { get; set; }
        [Required]
        public product_category product_Category { get; set; }

        public product_inventory product_Inventory { get; set; }
        public int product_InventoryID { get; set; }

    }
}
