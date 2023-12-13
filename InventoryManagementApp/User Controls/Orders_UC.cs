using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.UI;
using Microsoft.EntityFrameworkCore;


namespace InventoryManagementApp.User_Controls;

public partial class Orders_UC : UserControl
{
    public static Orders_UC instance;
    public static Sale transferSale;

    InventoryContext _db = new InventoryContext();
    Sale orders = new Sale();

    public Orders_UC()
    {
        InitializeComponent();

        ordersData.DataSource = _db.Sales.Select(o => new
        {
            კოდი = o.Id,
            პროდუქტი = o.Product.Name,
            კატეგორია = o.Product.Category.Name,
            ბრენდი = o.Product.Brand.Name,
            რაოდენობა = o.Amount,
            ლოკაცია = o.Location,
            გადახდის_ტიპი = o.PaymentMethod,
            შეკვეთის_ადგილი = o.PaymentArea,
            თარიღი = o.Date
        }).ToList();
    }

    private void edit_Btn_Click(object sender, EventArgs e)
    {
        var row = ordersData.CurrentRow;
        var orderIndex = ordersData.CurrentRow.Cells["კოდი"].Value.ToString();
        var order = _db.Sales.FirstOrDefault(p => p.Id.ToString() == orderIndex);
        transferSale = order;
        Edit_Order edit_order = new Edit_Order();
        edit_order.Show();
    }

    private void delete_Btn_Click(object sender, EventArgs e)
    {
        var row = ordersData.CurrentRow;
        var orderIndex = ordersData.CurrentRow.Cells["კოდი"].Value.ToString();
        var orderId = orderIndex;
        var order = _db.Sales.FirstOrDefault(p => p.Id.ToString() == orderId);

        order.DeleteOrder();
        order.DeleteTime = DateTime.Now;

        var result = _db.SaveChanges();


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
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                ბრენდი = o.Product.Brand.Name,
                რაოდენობა = o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
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
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                ბრენდი = o.Product.Brand.Name,
                რაოდენობა = o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
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

    }
}
