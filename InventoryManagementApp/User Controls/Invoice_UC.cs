using InventoryManagementApp.Data;

namespace InventoryManagementApp.User_Controls
{
    public partial class Invoice_UC : UserControl
    {
        InventoryContext _db = new InventoryContext();
        public Invoice_UC()
        {
            InitializeComponent();
            int shippedCount = _db.Sales.Count(sale => sale.Activity == Common.Enums.Activity.გზაშია);
            label1.Text = shippedCount.ToString();
        }
    }
}
