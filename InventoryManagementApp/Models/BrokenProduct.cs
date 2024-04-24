using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Models
{
    public class BrokenProduct
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string? Description { get; set; }
        public Product? Product { get; set; }
        public bool IsDeleted { get; set; }
        public void DeleteBrokenProduct()
        {
            IsDeleted = true;
        }
    }
}
