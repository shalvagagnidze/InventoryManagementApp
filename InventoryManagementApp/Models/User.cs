using InventoryManagementApp.Common.Enums;

namespace InventoryManagementApp.Models;

public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public string? UserName { get; set; }
    public string? UserPassword { get; set; }
    public Role Role { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsDeleted { get; set; }
    
    public void DeleteUser()
    {
        IsDeleted = true;
    }
}
