using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp.User_Controls
{
    public partial class Products_UC : UserControl
    {
        InventoryContext _db = new InventoryContext();
        public Products_UC()
        {
            InitializeComponent();          
        }

        private void Products_UC_Load(object sender, EventArgs e)
        {
            productData.DataSource = _db.Products.Select(s => new {s.Id, s.Name, s.Brand, s.Price, s.Description, s.Category,s.Status,s.TotalAmount }).ToList();
        }
    }
}
