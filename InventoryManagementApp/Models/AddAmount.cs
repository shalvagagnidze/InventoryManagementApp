namespace InventoryManagementApp.Models;

public class AddAmount
{
    public int Id { get; set; }
    public int Amount { get; set; }
    public DateTime? AdditionCreateDate { get; set; }
    public Product? Product { get; set; }
}
