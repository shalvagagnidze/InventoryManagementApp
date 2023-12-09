using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI
{
    public partial class Sell_Product : KryptonForm
    {
        InventoryContext _db = new InventoryContext();

        bool isChanged = false, isModified = false;
        DateTime date;
        int soldAmount;
        string location, payArea, payType;
        public Sell_Product()
        {
            InitializeComponent();
            var products = Products_UC.transferProduct;
            prodName.Text = products.Name;
            locationListBox.DataSource = Enum.GetValues(typeof(Location));
            payAreaListBox.DataSource = Enum.GetValues(typeof(PaymentArea));
            payTypeListBox.DataSource = Enum.GetValues(typeof(PaymentMethod));
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {

            date = soldDate.Value;
            soldAmount = (int)amountNumeric.Value;
            location = locationListBox.SelectedItem.ToString();
            payArea = payAreaListBox.SelectedItem.ToString();
            payType = payTypeListBox.SelectedItem.ToString();

            if (!isModified || !isChanged || locationListBox.SelectedIndex == -1 ||
                payAreaListBox.SelectedIndex == -1 || payTypeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("გთხოვთ,შეავსოთ მოცემული ყველა ველი!",
                           "წარუმატებელი ოპერაცია",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
            else
            {
                Sell();
            }
        }

        void Sell()
        {
            var products = Products_UC.transferProduct;
            location = locationListBox.SelectedItem.ToString();
            payArea = payAreaListBox.SelectedItem.ToString();
            payType = payTypeListBox.SelectedItem.ToString();

            Sale sale = new Sale()
            {
                Amount = soldAmount,
                Date = date,
                Location = (Location)Enum.Parse(typeof(Location), location),
                PaymentArea = (PaymentArea)Enum.Parse(typeof(PaymentArea), payArea),
                PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), payType),
                Product = products
            };

            _db.Sales.Add(sale);
            var totalSold = _db.TotalSolds.FirstOrDefault(x => x.Product == products);
            totalSold.TotalSoldAmount += soldAmount;
            var storage = _db.Storages.FirstOrDefault(s => s.Product == products);
            storage.TotalAmount -= soldAmount;
           // if(storage.TotalAmount< )
            _db.Update(products);
            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("გაყიდვა წარმატებით დაემატა!",
                           "წარმატებული დამატება",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("გაყიდვის დამატება ვერ მოხერხდა, თავიდან სცადეთ",
                           "წარუმატებელი დამატების მცდელობა",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
        }



        private void soldDate_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void amountNumeric_ValueChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}
