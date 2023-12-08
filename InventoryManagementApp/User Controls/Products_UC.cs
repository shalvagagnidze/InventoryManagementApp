using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.UI;
using Krypton.Toolkit;
using System.Data;

namespace InventoryManagementApp.User_Controls;

public partial class Products_UC : UserControl
{
    public static Products_UC instance;
    public static Product transferProduct;
    public static Category transferCategory;
    public static Brand transferBrand;
    InventoryContext _db = new InventoryContext();

    public Products_UC()
    {
        InitializeComponent();
        instance = this;
        panel2.BringToFront();
        sortCat_Btn.Visible = false;
        sortBrand_Btn.Visible = false;

    }

    private void Products_UC_Load(object sender, EventArgs e)
    {
        KryptonDataGridViewButtonColumn sell = (KryptonDataGridViewButtonColumn)productData.Columns["გაყიდვა"];
       
        productData.CellContentClick += new DataGridViewCellEventHandler(ProductData_CellContentClick);

        productData.DataSource = _db.Products.Select(s => new
        {
            კოდი = s.Code,
            დასახელება = s.Name,
            ბრენდი = s.Brand.Name,
            ფასი = s.Price,
            თვითღირებულება = s.NetCost,
            კატეგორია = s.Category.Name,
            რაოდენობა = s.Storage.TotalAmount,
            დამატების_თარიღი = s.CreateDate,
            სტატუსი = s.Status,
            აღწერა = s.Description,
            გაყიდვა = createSellButton(sell).Text
        }).ToList();

        productData.Columns["გაყიდვა"].DefaultCellStyle.ForeColor = Color.Green;

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
                KryptonDataGridViewButtonColumn sell = (KryptonDataGridViewButtonColumn)productData.Columns["გაყიდვა"];

                productData.DataSource = _db.Products.Select(s => new
                {
                    კოდი = s.Id,
                    დასახელება = s.Name,
                    ბრენდი = s.Brand.Name,
                    ფასი = s.Price,
                    თვითღირებულება = s.NetCost,
                    კატეგორია = s.Category.Name,
                    რაოდენობა = s.Storage.TotalAmount,
                    დამატების_თარიღი = s.CreateDate,
                    სტატუსი = s.Status,
                    აღწერა = s.Description,
                    გაყიდვა = createSellButton(sell).Text
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
        KryptonDataGridViewButtonColumn sell = (KryptonDataGridViewButtonColumn)productData.Columns["გაყიდვა"];

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
                                     რაოდენობა = s.Storage.TotalAmount,
                                     დამატების_თარიღი = s.CreateDate,
                                     სტატუსი = s.Status,
                                     აღწერა = s.Description,
                                     გაყიდვა = createSellButton(sell).Text
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
        KryptonDataGridViewButtonColumn sell = (KryptonDataGridViewButtonColumn)productData.Columns["გაყიდვა"];

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
            რაოდენობა = s.Storage.TotalAmount,
            დამატების_თარიღი = s.CreateDate,
            სტატუსი = s.Status,
            აღწერა = s.Description,
            გაყიდვა = createSellButton(sell).Text
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

        if (sortProd_Btn.Location == new System.Drawing.Point(350, 8))
        {
            var row = productData.CurrentRow;
            var prodIndex = productData.CurrentRow.Cells["კოდი"].Value.ToString();
            var prodId = prodIndex;
            var product = _db.Products.FirstOrDefault(p => p.Code == prodId);

            product.DeleteProduct();
            product.DeleteTime = DateTime.Now;

            var result = _db.SaveChanges();

            if (result > 0)
            {

                MessageBox.Show("პროდუქტი წარმატებით წაიშალა!",
                               "პროდუქტის წაშლა",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                KryptonDataGridViewButtonColumn sell = (KryptonDataGridViewButtonColumn)productData.Columns["გაყიდვა"];

                productData.DataSource = _db.Products.Select(s => new
                {
                    კოდი = s.Id,
                    დასახელება = s.Name,
                    ბრენდი = s.Brand.Name,
                    ფასი = s.Price,
                    თვითღირებულება = s.NetCost,
                    კატეგორია = s.Category.Name,
                    რაოდენობა = s.Storage.TotalAmount,
                    დამატების_თარიღი = s.CreateDate,
                    სტატუსი = s.Status,
                    აღწერა = s.Description,
                    გაყიდვა = createSellButton(sell).Text
                }).ToList();

            }
            else
            {
                MessageBox.Show("პროდუქტის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                               "შეცდომა წაშლისას",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
        }

        if (sortCat_Btn.Location == new System.Drawing.Point(350, 8))
        {
            var row = productData.CurrentRow;
            var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
            var category = _db.Categories.FirstOrDefault(p => p.Name == catBrandName);

            category.DeleteCategory();
            var result = _db.SaveChanges();

            if (result > 0)
            {

                MessageBox.Show("კატეგორია წარმატებით წაიშალა!",
                               "კატეგორიის წაშლა",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                productData.DataSource = _db.Categories.Select(c => new
                {
                    დასახელება = c.Name,
                    აღწერა = c.Description

                }).ToList();

            }
            else
            {
                MessageBox.Show("კატეგორიის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                               "შეცდომა წაშლისას",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
        }

        if (sortBrand_Btn.Location == new System.Drawing.Point(350, 8))
        {
            var row = productData.CurrentRow;
            var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
            var brand = _db.Brands.FirstOrDefault(p => p.Name == catBrandName);

            brand.DeleteBrand();

            var result = _db.SaveChanges();

            if (result > 0)
            {

                MessageBox.Show("ბრენდი წარმატებით წაიშალა!",
                               "ბრენდის წაშლა",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                productData.DataSource = _db.Brands.Select(c => new
                {
                    დასახელება = c.Name,
                    აღწერა = c.Description

                }).ToList();

            }
            else
            {
                MessageBox.Show("ბრენდის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                               "შეცდომა წაშლისას",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
        }
    }

    private void edit_Btn_Click(object sender, EventArgs e)
    {
        if (sortProd_Btn.Location == new System.Drawing.Point(350, 8))
        {
            var row = productData.CurrentRow;
            var prodIndex = productData.CurrentRow.Cells["კოდი"].Value.ToString();
            var product = _db.Products.FirstOrDefault(p => p.Code == prodIndex);
            transferProduct = product;
            Edit_Product edit_Product = new Edit_Product();
            edit_Product.Show();
        }
        else if (sortCat_Btn.Location == new System.Drawing.Point(350, 8))
        {
            var row = productData.CurrentRow;
            var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
            var category = _db.Categories.FirstOrDefault(p => p.Name == catBrandName);
            transferCategory = category;
            Edit_Category edit_Category = new Edit_Category();
            edit_Category.Show();
        }
        else if (sortBrand_Btn.Location == new System.Drawing.Point(350, 8))
        {
            var row = productData.CurrentRow;
            var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
            var brand = _db.Brands.FirstOrDefault(p => p.Name == catBrandName);
            transferBrand = brand;
            Edit_Brand edit_Brand = new Edit_Brand();
            edit_Brand.Show();
        }
    }

    private void ProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

        DataGridView grid = (DataGridView)sender;


        if (grid.Columns[e.ColumnIndex].Name == "გაყიდვა" && e.RowIndex >= 0)
        {
            var row = productData.CurrentRow;
            var prodIndex = productData.CurrentRow.Cells["კოდი"].Value.ToString();
            var product = _db.Products.FirstOrDefault(p => p.Code == prodIndex);
            transferProduct = product;
            Sell_Product sellProduct = new Sell_Product();
            sellProduct.Show();

        }
    }

    KryptonDataGridViewButtonColumn createSellButton(KryptonDataGridViewButtonColumn sell)
    {
        
        sell = new KryptonDataGridViewButtonColumn
        {
            Name = "Sell",
            HeaderText = "Buttons",
            Text = "გაყიდვა",
            UseColumnTextForButtonValue = true
        };

        return sell;
    }
}
