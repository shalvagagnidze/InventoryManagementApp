using InventoryManagementApp.Data;

namespace InventoryManagementApp.User_Controls
{
    public partial class Dashboard_UC : UserControl
    {
        InventoryContext _db = new InventoryContext();
        public Dashboard_UC()
        {
            InitializeComponent();
            int packedCount = _db.Sales.Count(sale => sale.Activity == Common.Enums.Activity.მზადდება);
            int shippedCount = _db.Sales.Count(sale => sale.Activity == Common.Enums.Activity.გზაშია);
            int deliveredCount = _db.Sales.Count(sale => sale.Activity == Common.Enums.Activity.მიწოდებულია);

            packText.Text = packedCount.ToString();
            shippingText.Text = shippedCount.ToString();
            deliveryText.Text = deliveredCount.ToString();
        }
    }

}
