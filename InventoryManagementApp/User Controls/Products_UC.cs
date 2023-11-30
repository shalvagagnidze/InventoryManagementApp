using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.UI;
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
            productData.DataSource = _db.Products.Select(s => new { s.Id, s.Name, s.Brand, s.Price, s.Description, s.Category, s.Status, s.TotalAmount }).ToList();
        }

        private void addProduct_Btn_Click(object sender, EventArgs e)
        {
            Add_Product addProduct = new Add_Product();
            addProduct.Show();

        }

        private void addCategory_Btn_Click(object sender, EventArgs e)
        {
            Add_Category addCategory = new Add_Category();
            addCategory.Show();
        }

        private void addBrand_Btn_Click(object sender, EventArgs e)
        {
            Add_Brand addBrand = new Add_Brand();
            addBrand.Show();
        }
    }
}
