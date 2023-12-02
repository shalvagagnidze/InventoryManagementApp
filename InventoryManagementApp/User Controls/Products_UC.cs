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
            panel2.BringToFront();
            sortCat_Btn.Visible = false;
            sortBrand_Btn.Visible = false;

        }

        private void Products_UC_Load(object sender, EventArgs e)
        {
            productData.DataSource = _db.Products.Select(s => new
            {
                კოდი = s.Id,
                დასახელება = s.Name,
                ბრენდი = s.Brand.Name,
                ფასი = s.Price,
                თვითღირებულება = s.NetCost,
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
            if (sortProd_Btn.Location == new System.Drawing.Point(350, 8))
            {


                if (Search_Txt.Text.Length > 0)
                {
                    string searchText = Search_Txt.Text;

                    SearchProduct(searchText);
                }
                else
                {
                    productData.DataSource = _db.Products.Select(s => new
                    {
                        კოდი = s.Id,
                        დასახელება = s.Name,
                        ბრენდი = s.Brand.Name,
                        ფასი = s.Price,
                        თვითღირებულება = s.NetCost,
                        კატეგორია = s.Category.Name,
                        რაოდენობა = s.TotalAmount,
                        სტატუსი = s.Status,
                        აღწერა = s.Description
                    }).ToList();

                }
            }
            else if (sortCat_Btn.Location == new System.Drawing.Point(350, 8))
            {
                if (Search_Txt.Text.Length > 0)
                {
                    string searchText = Search_Txt.Text;
                    SearchCategory(searchText);
                }
                else
                {
                    productData.DataSource = _db.Categories.Select(c => new
                    {
                        დასახელება = c.Name,
                        აღწერა = c.Description
                    }).ToList();
                }
            }
            else if (sortBrand_Btn.Location == new System.Drawing.Point(350, 8))
            {
                if (Search_Txt.Text.Length > 0)
                {
                    string searchText = Search_Txt.Text;
                    SearchBrand(searchText);
                }
                else
                {
                    productData.DataSource = _db.Brands.Select(b => new
                    {
                        დასახელება = b.Name,
                        მწარმოებელი = b.Origin,
                        აღწერა = b.Description
                    }).ToList();
                }
            }

        }

        public void SearchProduct(string searchText)
        {
            var search = _db.Products.Where(s => s.Name.Contains(searchText) ||
                                            s.Id.ToString().Contains(searchText) ||
                                            s.Category.Name.Contains(searchText) ||
                                            s.Brand.Name.Contains(searchText))
                                     .Select(s => new
                                     {
                                         კოდი = s.Id,
                                         დასახელება = s.Name,
                                         ბრენდი = s.Brand.Name,
                                         ფასი = s.Price,
                                         თვითღირებულება = s.NetCost,
                                         კატეგორია = s.Category.Name,
                                         რაოდენობა = s.TotalAmount,
                                         სტატუსი = s.Status,
                                         აღწერა = s.Description
                                     }).ToList();

            productData.DataSource = search;

        }

        public void SearchCategory(string searchText)
        {
            var search = _db.Categories.Where(c => c.Name.Contains(searchText))
                                       .Select(c => new
                                       {
                                           დასახელება = c.Name,
                                           აღწერა = c.Description
                                       }).ToList();

            productData.DataSource = search;
        }

        public void SearchBrand(string searchText)
        {
            var search = _db.Brands.Where(b => b.Name.Contains(searchText) ||
                                          b.Origin.Contains(searchText))
                                   .Select(b => new
                                   {
                                       დასახელება = b.Name,
                                       მწარმოებელი = b.Origin,
                                       აღწერა = b.Description
                                   }).ToList();

            productData.DataSource = search;
        }

        private void Search_Txt_Click(object sender, EventArgs e)
        {
            Search_Txt.Text = String.Empty;
        }

        private void sortProd_Btn_Click(object sender, EventArgs e)
        {
        }

        private void sortCat_Btn_Click(object sender, EventArgs e)
        {
            sortProd_Btn.Visible = false;
            sortBrand_Btn.Visible = false;

            sortCat_Btn.Location = new System.Drawing.Point(350, 8);
            sortProd_Btn.Location = new System.Drawing.Point(179, 8);
            sortBrand_Btn.Location = new System.Drawing.Point(8, 8);



            productData.DataSource = _db.Categories.Select(c => new
            {
                დასახელება = c.Name,
                აღწერა = c.Description
            }).ToList();
        }

        private void sortBrand_Btn_Click(object sender, EventArgs e)
        {
            sortProd_Btn.Visible = false;
            sortCat_Btn.Visible = false;

            sortBrand_Btn.Location = new System.Drawing.Point(350, 8);
            sortProd_Btn.Location = new System.Drawing.Point(179, 8);
            sortCat_Btn.Location = new System.Drawing.Point(8, 8);



            productData.DataSource = _db.Brands.Select(c => new
            {
                დასახელება = c.Name,
                მწარმოებელი = c.Origin,
                აღწერა = c.Description
            }).ToList();
        }

        private void sortProd_Btn_Click_1(object sender, EventArgs e)
        {
            sortCat_Btn.Visible = false;
            sortBrand_Btn.Visible = false;

            sortProd_Btn.Location = new System.Drawing.Point(350, 8);
            sortCat_Btn.Location = new System.Drawing.Point(179, 8);
            sortBrand_Btn.Location = new System.Drawing.Point(8, 8);


            panel2.SendToBack();
            productData.DataSource = _db.Products.Select(s => new
            {
                კოდი = s.Id,
                დასახელება = s.Name,
                ბრენდი = s.Brand.Name,
                ფასი = s.Price,
                თვითღირებულება = s.NetCost,
                კატეგორია = s.Category.Name,
                რაოდენობა = s.TotalAmount,
                სტატუსი = s.Status,
                აღწერა = s.Description
            }).ToList();
        }

        private void sort_Btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            sortProd_Btn.Visible = true;
            sortCat_Btn.Visible = true;
            sortBrand_Btn.Visible = true;
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            var row = productData.CurrentRow;           
            var prodIndex = productData.CurrentRow.Cells["კოდი"].Value.ToString();
            var prodId = int.Parse(prodIndex);
            var product = _db.Products.FirstOrDefault(p => p.Id == prodId);

            productData.Rows.Remove(row);

            _db.Products.Remove(product);

            var result = _db.SaveChanges();

            if(result > 0)
            {
                
                MessageBox.Show("პროდუქტი წარმატებით წაიშალა!",
                               "პროდუქტის წაშლა",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);              
            }
            else
            {
                MessageBox.Show("პროდუქტის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                               "შეცდომა წაშლისას",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
        }
    }
}
