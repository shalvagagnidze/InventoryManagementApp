using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp.UI
{
    public partial class Broken_Product : KryptonForm
    {
        public static Broken_Product Instance;
        int amount,userID;
        string description;
        InventoryContext _db = new InventoryContext();

        public Broken_Product()
        {
            InitializeComponent();
            Instance = this;
            var product = Products_UC.transferProduct;
            prodName_Label.Text = product.Name;
            userID = Login.userId;
        }

        private void Broken_Product_Load(object sender, EventArgs e)
        {

        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            var user = _db.Users.FirstOrDefault(o => o.Id == userID);
            amount = (int)BrokenNumeric.Value;
            description = brokenDesc_Txt.Text;
            var product = Products_UC.transferProduct;

            BrokenProduct broken = new BrokenProduct()
            {
              Amount = amount,
              Description = description,
              Product = product
            };

             _db.BrokenProducts.Add(broken);

            var storage = _db.Storages.FirstOrDefault(x => x.Product == product);

            storage!.TotalAmount -= amount;

            if (storage.TotalAmount == 0)
            {
                product.Status = StockStatus.ამოიწურა;
            }

            product.Storage = storage;

            _db.Update(product);

            var result = _db.SaveChanges();

            if(result > 0)
            {
                MessageBox.Show("დაზიანებული პროდუქტი წარმატებით დაემატა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("დაზიანებული პროდუქტების დამატება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
