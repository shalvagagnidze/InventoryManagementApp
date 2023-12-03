namespace InventoryManagementApp.Models;

public class Storage
{
    public int Id { get; set; }
    public int TotalAmount { get; set; }
    public Product? Product { get; set; }
}
