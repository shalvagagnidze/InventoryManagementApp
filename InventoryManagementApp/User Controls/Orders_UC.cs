using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.UI;
using Microsoft.EntityFrameworkCore;


namespace InventoryManagementApp.User_Controls;

public partial class Orders_UC : UserControl
{
    public static Orders_UC instance;
    public static Sale transferSale;
    int userID;
    InventoryContext _db = new InventoryContext();
    Sale orders = new Sale();

    public Orders_UC()
    {
        InitializeComponent();
        userID = Login.userId;
        fromDate.Value = DateTime.Now.Date;
        toDate.Value = DateTime.Now.Date;
        toDate.Enabled = false;
        fromDate.Enabled = false;
        dateCheck.Enabled = false;
        ordersData.RowPrePaint += ordersData_RowPrePaint;
        ordersData.DataSource = _db.Sales.Select(o => new
        {
            კოდი = o.Id,
            პროდუქტის_კოდი = o.Product.Code,
            პროდუქტი = o.Product.Name,
            კატეგორია = o.Product.Category.Name,
            ბრენდი = o.Product.Brand.Name,
            რაოდენობა = o.Amount,
            ფასი = o.DynamicPrice*o.Amount,
            ლოკაცია = o.Location,
            გადახდის_ტიპი = o.PaymentMethod,
            შეკვეთის_ადგილი = o.PaymentArea,
            მომხმარებელი = o.Customer.FirstName + " " + o.Customer.LastName,
            მდგომარეობა = o.Activity,
            თარიღი = o.Date
        }).ToList();
        


    }

    private void ordersData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        DataGridViewRow row = ordersData.Rows[e.RowIndex];

        if (row.Cells["მდგომარეობა"] is DataGridViewTextBoxCell cell)
        {
            string state = cell.Value.ToString();

            if (state == "მზადდება")
            {
                cell.Style.ForeColor = Color.Red;
            }
            else if (state == "გზაშია")
            {
                cell.Style.ForeColor = Color.Orange;
            }
            else if (state == "მიწოდებულია")
            {
                cell.Style.ForeColor = Color.Green;
            }
        }

    }

    private void edit_Btn_Click(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            var row = ordersData.CurrentRow;
            var orderIndex = ordersData.CurrentRow.Cells["კოდი"].Value.ToString();
            var order = _db.Sales.FirstOrDefault(p => p.Id.ToString() == orderIndex);
            transferSale = order;
            Edit_Order edit_order = new Edit_Order();
            edit_order.Show();
        }
        else
        {
            MessageBox.Show("თქვენ არ გაქვთ რედაქტირების უფლება",
                                   "შეზღუდული უფლებები",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
        }
        
    }

    private void delete_Btn_Click(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            if (MessageBox.Show("დარწმუნებული ხართ, რომ გსურთ წაშლა?", "ფრთხილად წაშლამდე!"
                           , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var row = ordersData.CurrentRow;
                var orderIndex = ordersData.CurrentRow.Cells["კოდი"].Value.ToString();
                var orderId = orderIndex;
                var order = _db.Sales.Include(c => c.Product).FirstOrDefault(p => p.Id.ToString() == orderId);
                var product = _db.Products.Include(c => c.Sales).FirstOrDefault(p => p.Code == order.Product.Code);
                order?.DeleteOrder();
                order!.DeleteTime = DateTime.Now;
                var totalSold = _db.TotalSolds.FirstOrDefault(x => x.Product == product);
                totalSold.TotalSoldAmount -= order.Amount;
                var storage = _db.Storages.FirstOrDefault(x => x.Product == product);
                storage.TotalAmount += order.Amount;

                product.Storage = storage;
                product.TotalSold = totalSold;

                if (storage.TotalAmount != 0)
                {
                    product.Status = StockStatus.მარაგშია;
                }
                else
                {
                    product.Status = StockStatus.ამოიწურა;
                }

                var response = _db.SaveChanges();

                if (response > 0)
                {
                    MessageBox.Show("შეკვეთა წარმატებით წაიშალა!",
                                      "შეკვეთის წაშლა",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                    ordersData.DataSource = _db.Sales.Select(o => new
                    {
                        კოდი = o.Id,
                        პროდუქტის_კოდი = o.Product.Code,
                        პროდუქტი = o.Product.Name,
                        კატეგორია = o.Product.Category.Name,
                        ბრენდი = o.Product.Brand.Name,
                        რაოდენობა = o.Amount,
                        ფასი = o.DynamicPrice * o.Amount,
                        ლოკაცია = o.Location,
                        გადახდის_ტიპი = o.PaymentMethod,
                        შეკვეთის_ადგილი = o.PaymentArea,
                        მომხმარებელი = o.Customer.FirstName + " " + o.Customer.LastName,
                        მდგომარეობა = o.Activity,
                        თარიღი = o.Date
                    }).ToList();

                }
                else
                {
                    MessageBox.Show("შეკვეთის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                                       "შეცდომა წაშლისას",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                }

            }
        }
        else
        {
            MessageBox.Show("თქვენ არ გაქვთ წაშლის უფლება",
                                   "შეზღუდული უფლებები",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
        }
        
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        var from_date = fromDate.Value.Date;
        var to_date = toDate.Value.Date.AddDays(1);
        if (dateCheck.Checked)
        {
            var onlyDate = _db.Sales.Where(d => d.Date == from_date).Select(d => d.Product);
            var onlySale = _db.Sales.Where(o => onlyDate.Contains(o.Product) && o.Date == from_date).Select(o => new
            {
                კოდი = o.Id,
                პროდუქტის_კოდი = o.Product.Code,
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                ბრენდი = o.Product.Brand.Name,
                რაოდენობა = o.Amount,
                ფასი = o.DynamicPrice * o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
                მომხმარებელი = o.Customer.FirstName + " " + o.Customer.LastName,
                მდგომარეობა = o.Activity,
                თარიღი = o.Date
            }).ToList();
            ordersData.DataSource = onlySale;
        }
        else
        {
            var dateSorting = _db.Sales.Where(d => d.Date >= from_date && d.Date <= to_date).Select(d => d.Product);
            var sales = _db.Sales.Where(o => dateSorting.Contains(o.Product) && o.Date >= from_date && o.Date <= to_date).Select(o => new
            {
                კოდი = o.Id,
                პროდუქტის_კოდი = o.Product.Code,
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                ბრენდი = o.Product.Brand.Name,
                რაოდენობა = o.Amount,
                ფასი = o.DynamicPrice * o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
                მომხმარებელი = o.Customer.FirstName + " " + o.Customer.LastName,
                მდგომარეობა = o.Activity,
                თარიღი = o.Date
            }).ToList();
            ordersData.DataSource = sales;
        }

    }

    private void dateCheck_CheckedChanged(object sender, EventArgs e)
    {
        if (dateCheck.Checked)
        {
            toDate.Enabled = false;
        }
        else
        {
            toDate.Enabled = true;
        }

    }

    private void Search_Txt_TextChanged(object sender, EventArgs e)
    {
        if (Search_Txt.Text.Length > 0)
        {
            string searchText = Search_Txt.Text;
            SearchOrder(searchText);
        }
        else
        {
            ordersData.DataSource = _db.Sales.Select(o => new
            {
                კოდი = o.Id,
                პროდუქტის_კოდი = o.Product.Code,
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                ბრენდი = o.Product.Brand.Name,
                რაოდენობა = o.Amount,
                ფასი = o.DynamicPrice * o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
                მომხმარებელი = o.Customer.FirstName + " " + o.Customer.LastName,
                მდგომარეობა = o.Activity,
                თარიღი = o.Date
            }).ToList();
        }

    }

    public void SearchOrder(string searchText)
    {
        var search = _db.Sales.Where(s => s.Product.Name.Contains(searchText) ||
                                          s.Product.Category.Name.Contains(searchText) ||
                                          s.Id.ToString().Contains(searchText) ||
                                          s.Product.Brand.Name.Contains(searchText) ||
                                          s.Product.Code.Contains(searchText))
                                  .Select(s => new
                                  {
                                      კოდი = s.Id,
                                      პროდუქტის_კოდი = s.Product.Code,
                                      პროდუქტი = s.Product.Name,
                                      კატეგორია = s.Product.Category.Name,
                                      ბრენდი = s.Product.Brand.Name,
                                      ფასი = s.DynamicPrice,
                                      რაოდენობა = s.Amount,
                                      ლოკაცია = s.Location,
                                      გადახდის_ტიპი = s.PaymentMethod,
                                      შეკვეთის_ადგილი = s.PaymentArea,
                                      მომხმარებელი = s.Customer.FirstName + " " + s.Customer.LastName,
                                      მდგომარეობა = s.Activity,
                                      თარიღი = s.Date
                                  }).ToList();

        ordersData.DataSource = search;

    }

    private void dateButton_CheckedChanged(object sender, EventArgs e)
    {
        if (dateButton.Checked)
        {
            toDate.Enabled = true;
            fromDate.Enabled = true;
            dateCheck.Enabled = true;

        }
        else
        {
            toDate.Enabled = false;
            fromDate.Enabled = false;
            dateCheck.Enabled = false;
        }
    }

    private void fromDate_ValueChanged(object sender, EventArgs e)
    {
        var from_date = fromDate.Value.Date;
        var to_date = toDate.Value.Date.AddDays(1);
        if (dateCheck.Checked)
        {
            var onlyDate = _db.Sales.Where(d => d.Date == from_date).Select(d => d.Product);
            var onlySale = _db.Sales.Where(d => d.Product.IsDeleted == false).Where(o => onlyDate.Contains(o.Product) && o.Date == from_date).Select(o => new
            {
                კოდი = o.Id,
                პროდუქტის_კოდი = o.Product.Code,
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                ბრენდი = o.Product.Brand.Name,
                რაოდენობა = o.Amount,
                ფასი = o.DynamicPrice * o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
                მომხმარებელი = o.Customer.FirstName+" "+o.Customer.LastName,
                მდგომარეობა = o.Activity,
                თარიღი = o.Date
            }).ToList();
            ordersData.DataSource = onlySale;
        }
        else
        {
            var dateSorting = _db.Sales.Where(d => d.Date >= from_date && d.Date <= to_date).Select(d => d.Product);
            var sales = _db.Sales.Where(o => dateSorting.Contains(o.Product) && o.Date >= from_date && o.Date <= to_date).Select(o => new
            {
                კოდი = o.Id,
                პროდუქტის_კოდი = o.Product.Code,
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                ბრენდი = o.Product.Brand.Name,
                რაოდენობა = o.Amount,
                ფასი = o.DynamicPrice * o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
                მომხმარებელი = o.Customer.FirstName + " " + o.Customer.LastName,
                მდგომარეობა = o.Activity,
                თარიღი = o.Date
            }).ToList();
            ordersData.DataSource = sales;
        }


    }

    private void toDate_ValueChanged(object sender, EventArgs e)
    {
        var from_date = fromDate.Value.Date;
        var to_date = toDate.Value.Date.AddDays(1);
        var dateSorting = _db.Sales.Where(d => d.Date >= from_date && d.Date <= to_date).Select(d => d.Product);
        var sales = _db.Sales.Where(o => dateSorting.Contains(o.Product) && o.Date >= from_date && o.Date <= to_date).Select(o => new
        {
            კოდი = o.Id,
            პროდუქტის_კოდი = o.Product.Code,
            პროდუქტი = o.Product.Name,
            კატეგორია = o.Product.Category.Name,
            ბრენდი = o.Product.Brand.Name,
            რაოდენობა = o.Amount,
            ფასი = o.DynamicPrice * o.Amount,
            ლოკაცია = o.Location,
            გადახდის_ტიპი = o.PaymentMethod,
            შეკვეთის_ადგილი = o.PaymentArea,
            მომხმარებელი = o.Customer.FirstName + " " + o.Customer.LastName,
            მდგომარეობა = o.Activity,
            თარიღი = o.Date
        }).ToList();
        ordersData.DataSource = sales;
    }

}
