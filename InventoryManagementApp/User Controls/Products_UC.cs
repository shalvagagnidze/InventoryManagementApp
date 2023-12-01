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
            productData.DataSource = _db.Products.Select(s => new {
                                                                    კოდი = s.Id,
                                                                    დასახელება = s.Name,
                                                                    ბრენდი = s.Brand.Name,
                                                                    ფასი = s.Price,
                                                                    ნეტო = s.NetCost,
                                                                    კატეგორია = s.Category.Name,
                                                                    რაოდენობა = s.TotalAmount,
                                                                    სტატუსი = s.Status,
                                                                    აღწერა = s.Description
                                                                    }).ToList();



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

        private void Search_Txt_TextChanged(object sender, EventArgs e)
        {
            if (Search_Txt.Text.Length > 0)
            {
                string searchText = Search_Txt.Text;

                Search(searchText);
            }
            else
            {
                productData.DataSource = _db.Products.Select(s => new { კოდი = s.Id,
                                                                        დასახელება = s.Name,
                                                                        ბრენდი = s.Brand.Name,
                                                                        ფასი = s.Price,
                                                                        ნეტო = s.NetCost,
                                                                        კატეგორია = s.Category.Name,                                                                      
                                                                        რაოდენობა = s.TotalAmount,
                                                                        სტატუსი = s.Status,
                                                                        აღწერა = s.Description
                                                                         }).ToList();

            }

        }

        public void Search(string searchText)
        {
            var search = _db.Products.Where(s => s.Name.Contains(searchText) ||
                                            s.Id.ToString().Contains(searchText) ||
                                            s.Category.Name.Contains(searchText)||
                                            s.Brand.Name.Contains(searchText))
                                     .Select(s => new
                                     {
                                         კოდი = s.Id,
                                         დასახელება = s.Name,
                                         ბრენდი = s.Brand.Name,
                                         ფასი = s.Price,
                                         ნეტო = s.NetCost,
                                         კატეგორია = s.Category.Name,
                                         რაოდენობა = s.TotalAmount,
                                         სტატუსი = s.Status,
                                         აღწერა = s.Description
                                     }).ToList();

            productData.DataSource = search;

        }

        private void Search_Txt_Click(object sender, EventArgs e)
        {
            Search_Txt.Text = String.Empty;
        }
    }
}
