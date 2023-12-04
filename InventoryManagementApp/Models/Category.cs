using System.ComponentModel.DataAnnotations;

namespace InventoryManagementApp.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Product>? Products { get; }
    public bool IsDeleted { get; set; }
    public void DeleteCategory()
    {
        IsDeleted = true;
    }
}
