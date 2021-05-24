using DepartmentalStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Data
{
    public class DepartmentStoreContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<ProductCategory> Productcategory { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<SupplierProduct> SupplierProduct { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }

        public static readonly ILoggerFactory ConsoleLoggerFactory =
            LoggerFactory.Create(builder =>
            {
                builder
                .AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information)
                .AddConsole();
            });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host = localhost; Username = postgres; Password = harshit @$; Database = DepartmentalStore4");
            optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory).EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure Role
            modelBuilder.Entity<Role>().HasKey(r => r.Id);
            modelBuilder.Entity<Role>().Property(x => x.RoleName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Role>().Property(x => x.Description).HasMaxLength(512);
            base.OnModelCreating(modelBuilder);

            //Configure Address
            modelBuilder.Entity<Address>().HasKey(r => r.Id);
            modelBuilder.Entity<Address>().Property(x => x.AddressLine1).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.AddressLine2).HasMaxLength(128);
            modelBuilder.Entity<Address>().Property(x => x.City).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.State).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.Pincode).HasMaxLength(10).IsRequired();

            //Configure Staff
            modelBuilder.Entity<Staff>().HasKey(r => r.Id);
            modelBuilder.Entity<Staff>().Property(x => x.FirstName).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.LastName).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.PhoneNumber).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.Gender).HasMaxLength(1).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.Salary).IsRequired();
            modelBuilder.Entity<Staff>().HasOne(x => x.Address).WithMany(x=>x.Staff).HasForeignKey(x => x.AddressId);
            modelBuilder.Entity<Staff>().HasOne(x => x.Role).WithMany(x=>x.Staff).HasForeignKey(x => x.RoleId);

            //Configure Product
            modelBuilder.Entity<Product>().HasKey(r => r.ProductId);
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Manufacturer).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.ShortCode).HasMaxLength(10).IsRequired();
            
            //modelBuilder.Entity<Product>().HasIndex(r => r.CostPrice).HasFilter("ALTER TABLE Product ADD CONSTRAINT MyUniqueConstraint CHECK (CostPrice > 0);");

             modelBuilder.Entity<Product>().Property(x => x.CostPrice).IsRequired();
            //modelBuilder.Entity<Product>().HasIndex(r => r.SellingPrice).HasFilter("ALTER TABLE Product ADD CONSTRAINT MyUniqueConstraint CHECK (SellingPrice > 0);");
             modelBuilder.Entity<Product>().Property(x => x.SellingPrice).IsRequired();

            //Configure Category
            modelBuilder.Entity<Category>().HasKey(r => r.CategoryId);
            modelBuilder.Entity<Category>().Property(r => r.CategoryName).HasMaxLength(128).IsRequired();
            
            //Configure ProductCategory
            modelBuilder.Entity<ProductCategory>().HasKey(pc => new { pc.ProductId, pc.CategoryId });


            //Configure ProductCategory
            //modelBuilder.Entity<Product>()
            //    .HasMany<Category>(p => p.Categories)
            //    .WithMany(c => c.Products)
            //    .Map(cp =>
            //    {
            //        cp.MapLeftKey("ProductRefId");
            //        cp.MapRightKey("CategoryRefId");
            //        cp.ToTable("ProductCategory");
            //    });


            //Configure Inventory
            modelBuilder.Entity<Inventory>().HasKey(r => r.InventoryId);
            modelBuilder.Entity<Inventory>().Property(x => x.ProductId).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Inventory>().Property(x => x.InStock).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Inventory>().Property(x => x.ProductQuantity).IsRequired();

            //Configure Supplier
            modelBuilder.Entity<Supplier>().HasKey(r => r.SupplierId);
            modelBuilder.Entity<Supplier>().Property(x => x.SupplierName).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.Email).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.City).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.State).HasMaxLength(128).IsRequired();

            //Configure SupplierProduct
            modelBuilder.Entity<SupplierProduct>().HasKey(pc => new { pc.ProductId, pc.SupplierId });

            //Configure PurchaseOrder
            modelBuilder.Entity<PurchaseOrder>().HasKey(r => r.PurchaseOrderId);
            modelBuilder.Entity<PurchaseOrder> ().Property(x => x.ProductId).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<PurchaseOrder> ().Property(x => x.SupplierId).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<PurchaseOrder>().Property(x => x.OrderDate).IsRequired();
            modelBuilder.Entity<PurchaseOrder>().Property(x => x.amount).IsRequired();
            modelBuilder.Entity<PurchaseOrder>().Property(x => x.QuantityNeeded).IsRequired();
           
        }
    }
}
