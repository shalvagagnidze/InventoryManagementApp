using InventoryManagementApp.Common.Enums;

namespace InventoryManagementApp.Models;

public class Sale
{
    public int Id { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? DeleteTime { get; set; }
    public int Amount { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }
    public PaymentArea? PaymentArea { get; set; }
    public Product? Product { get; set; }
    public Location? Location { get; set; }
    public Customer? Customer { get; set; }
    public bool IsDeleted { get; set; }
    public void DeleteOrder()
    {
        IsDeleted = true;
    }
}
