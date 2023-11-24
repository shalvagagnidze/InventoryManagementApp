using InventoryManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["InventoryDataBase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                        .HasKey(p => p.Id);
            modelBuilder.Entity<Product>()
                        .Property(p => p.Id)
                        .ValueGeneratedNever();
            modelBuilder.Entity<Product>()
                        .HasOne(p => p.Category)
                        .WithMany(c => c.Products)
                        .HasForeignKey(p => p.CategoryID);
            modelBuilder.Entity<Product>()
                        .HasOne(p => p.Brand)
                        .WithMany(b => b.Products)
                        .HasForeignKey(p => p.BrandID);
            modelBuilder.Entity<Location>()
                        .HasKey(l => l.Id);
            modelBuilder.Entity<Role>()
                        .HasKey(r => r.Id);
            modelBuilder.Entity<Brand>()
                        .HasKey(b => b.Id);
            modelBuilder.Entity<Sale>()
                        .HasKey(s => s.Id);
            



        }
    }
}
