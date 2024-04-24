using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;
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
    public partial class Edit_BrokenProduct : KryptonForm
    {
        public static Edit_BrokenProduct instance;
        InventoryContext _db = new InventoryContext();
        int amount,firstAmount,lastAmount;
        string? description;
        bool isModified = false;
        public Edit_BrokenProduct()
        {
            InitializeComponent();
            instance = this;
            var product = Products_UC.transferProduct;
            var brokenProduct = Products_UC.transferBrokenProduct;
            prodName_Label.Text = product.Name;
            BrokenNumeric.Value = (int)brokenProduct.Amount;
            firstAmount = (int)brokenProduct.Amount;
            brokenDesc_Txt.Text = brokenProduct.Description;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            var product = Products_UC.transferProduct;
            var brokenProduct = Products_UC.transferBrokenProduct;

            amount = (int)BrokenNumeric.Value;
            description = brokenProduct.Description;

            if (isModified)
            {
                brokenProduct.Amount = amount;
                lastAmount = firstAmount - amount;
                var storage = _db.Storages.FirstOrDefault(s => s.Product == product);
                storage!.TotalAmount += lastAmount;
            }

            if (brokenDesc_Txt.Modified)
            {
                brokenProduct.Description = description;
            }

            _db.Update(brokenProduct);

            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("დაზიანებული პროდუქტი წარმატებით განახლდა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("დაზიანებული პროდუქტის განახლება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }

        private void BrokenNumeric_ValueChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}
