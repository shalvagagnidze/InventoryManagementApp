using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.Models;

namespace InventoryManagementApp.User_Controls
{       
    public partial class Orders_UC : UserControl
    {
        InventoryContext _db = new InventoryContext();
        Sale orders = new Sale();
       
        public Orders_UC()
        {
            InitializeComponent();
            
            ordersData.DataSource = _db.Sales.Select(o => new
            { 
                პროდუქტი = o.Product.Name,
                კატეგორია = o.Product.Category.Name,
                რაოდენობა = o.Amount,
                ლოკაცია = o.Location,
                გადახდის_ტიპი = o.PaymentMethod,
                შეკვეთის_ადგილი = o.PaymentArea,
                თარიღი = o.Date
            }).ToList();
        }
    }
}
