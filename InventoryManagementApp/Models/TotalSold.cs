namespace InventoryManagementApp.Models;

public class TotalSold
{
    public int Id { get; set; }
    public int TotalSoldAmount { get; set; }
    public Product? Product { get; set; }
}
