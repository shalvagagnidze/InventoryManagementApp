using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double NetCost { get; set; }
        public int TotalAmount { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }


        public Category Category { get; set; }
        public Brand Brand { get; set; }
        
    }
}
