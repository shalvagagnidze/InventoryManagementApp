using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI
{
    public partial class Edit_Order : KryptonForm
    {
        public static Edit_Order instance;
        InventoryContext _db = new InventoryContext();
        int amount, firstAmount;
        string location, payArea, payType, firstLoc, firstArea, firstType;
        DateTime date, firstDate;
        bool isNumericModified;
        DataGridView ordersData = new DataGridView();
        public Edit_Order()
        {
            InitializeComponent();
            instance = this;
            var sale = Orders_UC.transferSale;
            var locationsListBox = Enum.GetValues(typeof(Location));
            var payAreaList = Enum.GetValues(typeof(PaymentArea));
            var payTypeList = Enum.GetValues(typeof(PaymentMethod));
            locationListBox.DataSource = locationsListBox;
            payAreaListBox.DataSource = payAreaList;
            payTypeListBox.DataSource = payTypeList;
            soldDate.Value = (DateTime)sale.Date;
            firstDate = (DateTime)sale.Date;
            amountNumeric.Value = (int)sale.Amount;
            firstAmount = (int)sale.Amount;
            firstLoc = sale.Location.ToString();
            firstArea = sale.PaymentArea.ToString();
            firstType = sale.PaymentMethod.ToString();
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            var sale = Orders_UC.transferSale;
            var product = _db.Products.FirstOrDefault(p => p.Sales.Contains(sale));
            amount = (int)amountNumeric.Value;
            date = soldDate.Value;
            location = locationListBox.SelectedIndex.ToString();
            payArea = payAreaListBox.SelectedIndex.ToString();
            payType = payTypeListBox.SelectedIndex.ToString();

            if (isNumericModified)
            {
                sale.Amount = amount;
                var totalSold = _db.TotalSolds.FirstOrDefault(p => p.Product == product);
                var storage = _db.Storages.FirstOrDefault(s => s.Product == product);

                if (amount > firstAmount)
                {
                    totalSold.TotalSoldAmount += (amount - firstAmount);
                    storage.TotalAmount -= (amount - firstAmount);
                }
                else if (amount < firstAmount)
                {
                    totalSold.TotalSoldAmount -= (firstAmount - amount);
                    storage.TotalAmount += (firstAmount - amount);
                }
            }

            if (soldDate.Value != firstDate)
            {
                sale.Date = date;
            }

            if (location != firstLoc)
            {
                sale.Location = (Location)Enum.Parse(typeof(Location), location);
            }

            if (payArea != firstArea)
            {
                sale.PaymentArea = (PaymentArea)Enum.Parse(typeof(PaymentArea), payArea);
            }

            if (payType != firstType)
            {
                sale.PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), payType);
            }

            if (toBePacked.Checked)
            {
                sale.Activity = Activity.მზადდება;
            }

            if (shipped.Checked)
            {
                sale.Activity = Activity.გზაშია;
            }

            if (delivered.Checked)
            {
                sale.Activity = Activity.მიწოდებულია;
            }


            _db.Update(sale);
            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("შეკვეთა წარმატებით განახლდა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);               
                this.Hide();
            }
            else
            {
                MessageBox.Show("შეკვეთის განახლება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void amountNumeric_ValueChanged(object sender, EventArgs e)
        {
            isNumericModified = true;
        }

        private void toBePacked_CheckedChanged(object sender, EventArgs e)
        {
            shipped.Checked = false;
            delivered.Checked = false;
        }

        private void shipped_CheckedChanged(object sender, EventArgs e)
        {
            toBePacked.Checked = false;
            delivered.Checked = false;
        }

        private void delivered_CheckedChanged(object sender, EventArgs e)
        {
            toBePacked.Checked = false;
            shipped.Checked = false;
        }
    }
}
