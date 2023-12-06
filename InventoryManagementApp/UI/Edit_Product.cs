using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI
{
    public partial class Edit_Product : KryptonForm
    {
        public static Edit_Product instance;

        InventoryContext _db = new InventoryContext();

        string code, price, netCost, name, description;
        int addAmount;
        bool isModified = false;
        public Edit_Product()
        {
            InitializeComponent();
            instance = this;
            var products = Products_UC.transferProduct;
            var categoryBox = _db.Categories.Select(x => x.Name).ToList();
            var brandBox = _db.Brands.Select(x => x.Name).ToList();
            categoryListBox.DataSource = categoryBox;
            brandList.DataSource = brandBox;
            prodID_Txt.Text = products.Code;
            price_Txt.Text = products.Price.ToString();
            netCost_Txt.Text = products.NetCost.ToString();
            productName_Txt.Text = products.Name;
            prodDesc_Txt.Text = products.Description;
            categoryListBox.DataSource = categoryBox;
            brandList.DataSource = brandBox;

        }


        private void prodSave_Btn_Click(object sender, EventArgs e)
        {
            var products = Products_UC.transferProduct;

            code = prodID_Txt.Text;
            price = price_Txt.Text;
            netCost = netCost_Txt.Text;
            name = productName_Txt.Text;
            description = prodDesc_Txt.Text;
            addAmount = (int)productNumeric.Value;

            if (prodID_Txt.Modified)
            {
                products.Code = code;
            }

            if (price_Txt.Modified)
            {
                products.Price = decimal.Parse(price);
            }

            if (netCost_Txt.Modified)
            {
                products.NetCost = decimal.Parse(netCost);
            }

            if (productName_Txt.Modified)
            {
                products.Name = name;
            }

            if (prodDesc_Txt.Modified)
            {
                products.Description = description;
            }

            if (isModified)
            {
                AddAmount addamounts = new AddAmount
                {
                    Amount = addAmount,
                    AdditionCreateDate = DateTime.Now,
                    Product = products
                };

                _db.AddAmounts.Add(addamounts);
                var storage = _db.Storages.FirstOrDefault(s => s.Product == products);
                storage.TotalAmount += addAmount;
            }


            _db.Update(products);
            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("პროდუქტი წარმატებით განახლდა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("პროდუქტის განახლება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }

        private void productNumeric_ValueChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}
