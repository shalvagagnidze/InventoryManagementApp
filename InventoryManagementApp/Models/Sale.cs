using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string PaymentType { get; set; }
        public int LocationID { get; set; }

        public List<Product> Products { get; set; }
        public List<Location> Locations { get; set; }
    }
}
