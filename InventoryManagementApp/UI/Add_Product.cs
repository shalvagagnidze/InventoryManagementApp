using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using Krypton.Toolkit;
using System.Data;

namespace InventoryManagementApp.UI;

public partial class Add_Product : KryptonForm
{
    InventoryContext _db = new InventoryContext();

    int categoryId, brandId, productAmount;
    decimal productPrice, productNetCost;
    string code, productName, productDescription, categoryName, brandName;
    public Add_Product()
    {
        InitializeComponent();
        var categoryBox = _db.Categories.Select(x => x.Name).ToList();
        var brandBox = _db.Brands.Select(x => x.Name).ToList();
        categoryListBox.DataSource = categoryBox;
        brandList.DataSource = brandBox;
    }


    private void prodSave_Btn_Click(object sender, EventArgs e)
    {
        code = prodID_Txt.Text;
        productPrice = decimal.Parse(price_Txt.Text);
        productNetCost = decimal.Parse(netCost_Txt.Text);
        productAmount = int.Parse(prodAmount_Txt.Text);
        productName = productName_Txt.Text;
        productDescription = prodDesc_Txt.Text;

        var selectedCategory = categoryListBox.SelectedItem;
        var selectedBrand = brandList.SelectedItem;

        categoryName = selectedCategory.ToString();
        brandName = selectedBrand.ToString();

        var category = _db.Categories.FirstOrDefault(x => x.Name == categoryName).Id;

        var brand = _db.Brands.FirstOrDefault(x => x.Name == brandName).Id;

        if (category != null)
        {
            categoryId = category;
        }
        else
        {
            MessageBox.Show("თქვენ მიერ მონიშნული კატეგორია არ იძებნება, ხელახლა სცადეთ",
                            "კატეგორია ვერ მოიძებნა",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        if (brand != null)
        {
            brandId = brand;
        }
        else
        {
            MessageBox.Show("თქვენ მიერ მონიშნული ბრენდი არ იძებნება, ხელახლა სცადეთ",
                            "ბრენდი ვერ მოიძებნა",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        if (string.IsNullOrWhiteSpace(productName_Txt.Text) ||
           string.IsNullOrWhiteSpace(productName_Txt.Text) ||
           string.IsNullOrWhiteSpace(price_Txt.Text) ||
           string.IsNullOrWhiteSpace(netCost_Txt.Text) ||
           string.IsNullOrWhiteSpace(prodDesc_Txt.Text))

        {
            MessageBox.Show("გთხოვთ, შეავსოთ მოცემული ყველა ველი",
                            "შესავსები ველი ცარიელია",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
        else
        {
            AddProduct();
        }


    }

    void AddProduct()
    {
        var categories = _db.Categories.FirstOrDefault(x => x.Id == categoryId);
        var brands = _db.Brands.FirstOrDefault(x => x.Id == brandId);

        Models.Storage storage = new Models.Storage();
        storage.TotalAmount = productAmount;

        StockStatus status = StockStatus.მარაგშია;
        DateTime createDate = DateTime.Now;
        Product product = new Product()
        {
            Code = code,
            Name = productName,
            Price = productPrice,
            NetCost = productNetCost,
            Storage = storage,
            Category = categories,
            Brand = brands,
            Status = status,
            CreateDate = createDate,
            IsDeleted = false,
            Description = productDescription

        };

        _db.Products.Add(product);

        var response = _db.SaveChanges();

        if (response > 0)
        {
            MessageBox.Show("პროდუქტი წარმატებით დაემატა!",
                            "წარმატებული შენახვა",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Hide();
        }
        else
        {
            MessageBox.Show("პროდუქტის დამატება ვერ მოხერხდა, თავიდან სცადეთ!",
                            "დამატების წარუმატებელი მცდელობა",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

    }

    private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        //categoryName = categoryListBox.Text;

    }

    private void brandList_SelectedIndexChanged(object sender, EventArgs e)
    {
        //brandName = brandList.Text;
    }
}
