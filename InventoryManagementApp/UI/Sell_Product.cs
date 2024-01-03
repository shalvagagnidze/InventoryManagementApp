using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI;

public partial class Sell_Product : KryptonForm
{
    InventoryContext _db = new InventoryContext();

    bool isChanged = false, isModified = false;
    DateTime date;
    int soldAmount;
    string location, payArea, payType, custFirstName, custLastName, custNumber;
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
        date = soldDate.Value.Date;
        soldAmount = (int)amountNumeric.Value;
        location = locationListBox.SelectedItem.ToString();
        payArea = payAreaListBox.SelectedItem.ToString();
        payType = payTypeListBox.SelectedItem.ToString();
        var products = Products_UC.transferProduct;
        var storage = _db.Storages.FirstOrDefault(s => s.Product == products);

        if (!isModified || locationListBox.SelectedIndex == -1 ||
            payAreaListBox.SelectedIndex == -1 || payTypeListBox.SelectedIndex == -1)
        {
            MessageBox.Show("გთხოვთ,შეავსოთ მოცემული ყველა ველი!",
                       "წარუმატებელი ოპერაცია",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }
        else
        {
            if(storage.TotalAmount - soldAmount < 0)
            {
                MessageBox.Show("მარაგში არ გაქვთ საკმარისი პროდუქტი, სცადეთ თავიდან!",
                       "გაყიდვა ვერ მოხერხდა",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            else
            {
               Sell();
            }
            
        }
    }

    void Sell()
    {
        var products = Products_UC.transferProduct;
        location = locationListBox.SelectedItem.ToString();
        payArea = payAreaListBox.SelectedItem.ToString();
        payType = payTypeListBox.SelectedItem.ToString();
        custFirstName = customerFirstName.Text;
        custLastName = customerLastName.Text;
        custNumber = phoneNumber.Text;           

        Customer customer = new Customer()
        {
            FirstName = custFirstName,
            LastName = custLastName,
            PhoneNumber = custNumber,
        };

        Sale sale = new Sale()
        {
            Amount = soldAmount,
            Date = date,
            Location = (Location)Enum.Parse(typeof(Location), location),
            PaymentArea = (PaymentArea)Enum.Parse(typeof(PaymentArea), payArea),
            PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), payType),
            Product = products,
            IsDeleted = false,   
            Customer = customer,
            Activity = Activity.მზადდება           
        };

        

        _db.Sales.Add(sale);
        _db.Customers.Add(customer);
        var totalSold = _db.TotalSolds.FirstOrDefault(x => x.Product == products);
        totalSold.TotalSoldAmount += soldAmount;
        var storage = _db.Storages.FirstOrDefault(s => s.Product == products);
        storage.TotalAmount -= soldAmount;
       if(storage.TotalAmount == 0)
        {
            products.Status = StockStatus.ამოიწურა;
        }

       products.Storage = storage;
       products.TotalSold = totalSold;
       _db.Update(products);
        
        var response = _db.SaveChanges();

        if (response > 0)
        {
            MessageBox.Show("გაყიდვა წარმატებით დაემატა!",
                       "წარმატებული დამატება",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            this.Hide();
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
