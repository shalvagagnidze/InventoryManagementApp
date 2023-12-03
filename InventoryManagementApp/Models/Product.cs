using InventoryManagementApp.Common.Enums;

namespace InventoryManagementApp.Models;

public class Product
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public decimal NetCost { get; set; }
    public Storage? Storage { get; set; }
    public AddAmount? AddAmount { get; set; }
    public StockStatus? Status { get; set; }
    public string? Description { get; set; }
    public Category? Category { get; set; }
    public Brand? Brand { get; set; }
    public List<Sale>? Sales { get; set; }
    public DateTime? CreateDate { get; set; }
    public DateTime DeleteTime { get; set; }
    public bool IsDeleted { get; set; }
    public void DeleteProduct()
    {
        IsDeleted = true;
    }
}
