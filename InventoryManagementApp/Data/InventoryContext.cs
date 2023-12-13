using InventoryManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace InventoryManagementApp.Data;

public class InventoryContext : DbContext
{
    public InventoryContext()
    {

    }
    public InventoryContext(DbContextOptions<InventoryContext> options)
        : base(options)
    {

    }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<AddAmount> AddAmounts { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<TotalSold> TotalSolds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["InventoryDataBase"].ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasQueryFilter(o => !o.IsDeleted);
        modelBuilder.Entity<User>().HasQueryFilter(o => !o.IsDeleted);
        modelBuilder.Entity<Category>().HasQueryFilter(o => !o.IsDeleted);
        modelBuilder.Entity<Brand>().HasQueryFilter(o => !o.IsDeleted);
        modelBuilder.Entity<Sale>().HasQueryFilter(o => !o.IsDeleted);

        modelBuilder.Entity<Product>()
                    .HasKey(p => p.Id);                 

        modelBuilder.Entity<Product>()
                    .HasOne(p => p.Category)
                    .WithMany(c => c.Products);

        modelBuilder.Entity<Product>()
                    .HasOne(p => p.Storage);

        modelBuilder.Entity<Product>()
                    .HasOne(p => p.TotalSold);

        modelBuilder.Entity<Product>()
                    .HasMany(p => p.AddAmount);

        modelBuilder.Entity<Product>()
                    .HasMany(p => p.Sales);

        modelBuilder.Entity<Product>()
                    .HasMany(p => p.Sales)
                    .WithOne(s => s.Product);

        modelBuilder.Entity<Product>()
                    .HasMany(p => p.AddAmount)
                    .WithOne(a => a.Product);

        modelBuilder.Entity<Product>()
                    .HasOne(p => p.Storage)
                    .WithOne(s => s.Product)
                    .HasForeignKey<Storage>(s => s.Id)
                    .HasPrincipalKey<Product>(p => p.Id);

        modelBuilder.Entity<Product>()
                    .HasOne(p => p.TotalSold)
                    .WithOne(s => s.Product)
                    .HasForeignKey<TotalSold>(p => p.Id)
                    .HasPrincipalKey<Product>(s => s.Id);            

        modelBuilder.Entity<Product>()
                    .HasOne(p => p.Brand)
                    .WithMany(b => b.Products);

        modelBuilder.Entity<Brand>()
                    .HasKey(b => b.Id);

        modelBuilder.Entity<Sale>()
                    .HasKey(s => s.Id);

        modelBuilder.Entity<Sale>()
                    .HasOne(s => s.Product)
                    .WithMany(s => s.Sales);

        modelBuilder.Entity<User>()
                    .HasKey(u => u.Id);

        modelBuilder.Entity<Storage>()
                    .HasKey(u => u.Id);

        modelBuilder.Entity<AddAmount>()
                    .HasKey(a => a.Id);

        modelBuilder.Entity<AddAmount>()
                    .HasOne(a => a.Product)
                    .WithMany(a => a.AddAmount);
                    
        modelBuilder.Entity<TotalSold>()
                    .HasKey(a => a.Id);
    }
}
