using DepartmentalStore.Data;
using DepartmentalStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore
{
    public class AddOperations
    {
        public static DepartmentStoreContext context = new DepartmentStoreContext();
        public static void AddRole()
        {
            var role = new Role { RoleName = "Manager", Description = "Manages the store" };
            var role1 = new Role { RoleName = "Product Keeper", Description = "Manages the products" };
            var role2 = new Role { RoleName = "Accountant", Description = "Manages the Bills" };
            context.Add(role);
            context.Add(role1);
            context.Add(role2);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(role1.Description);
        }

        public static void AddAddress()
        {
            var Address = new Address { AddressLine1 = "242/1", AddressLine2 = "Arya Nagar", City = "Firozabad", State = "Uttar Pradesh", Pincode = "283203" };
            var Address1 = new Address { AddressLine1 = "RKGIT", AddressLine2 = "Delhi-Meerut Rode", City = "Ghaziabad", State = "Uttar Pradesh", Pincode = "2001003" };
            var Address2 = new Address { AddressLine1 = "KIET", AddressLine2 = "Modi Nagar", City = "Ghaziabad", State = "Uttar Pradesh", Pincode = "283202" };
            var Address3 = new Address { AddressLine1 = "1B", AddressLine2 = "Sanjay Palace", City = "Agra", State = "Uttar Pradesh", Pincode = "283202" };
            context.Add(Address);
            context.Add(Address1);
            context.Add(Address2);
            context.Add(Address3);
            context.SaveChanges();
        }

        public static void AddStaff()
        {
            var Staff = new Staff { FirstName = "Rohit", LastName = "Pandey", PhoneNumber = "9876545556", Gender = 'M', Salary = 10000, AddressId = 1, RoleId = 1 };
            var Staff1 = new Staff { FirstName = "Yanshik", LastName = "Rajput", PhoneNumber = "9873330556", Gender = 'M', Salary = 19000, AddressId = 2, RoleId = 1 };
            var Staff2 = new Staff { FirstName = "Ram", LastName = "Pandey", PhoneNumber = "8343735343", Gender = 'M', Salary = 20000, AddressId = 3, RoleId = 2 };
            var Staff3 = new Staff { FirstName = "Gaurav", LastName = "Raj", PhoneNumber = "5343534534", Gender = 'M', Salary = 20000, AddressId = 3, RoleId = 2 };
            var Staff4 = new Staff { FirstName = "Prerna", LastName = "Pachuari", PhoneNumber = "8782352355", Gender = 'F', Salary = 34000, AddressId = 4, RoleId = 3 };
            var Staff5 = new Staff { FirstName = "Rashmi", LastName = "Varshney", PhoneNumber = "6763434355", Gender = 'F', Salary = 70000, AddressId = 1, RoleId = 3 };
            context.Add(Staff);
            context.Add(Staff1);
            context.Add(Staff2);
            context.Add(Staff3);
            context.Add(Staff4);
            context.Add(Staff5);
            context.SaveChanges();
        }

        public static void AddProduct()
        {
            List<Product> products = new List<Product>();
            var product = (new Product { ProductName = "Tv", Manufacturer = "LG", ShortCode = "tv", CostPrice = 10000, SellingPrice = 15000 });
            var product1 = (new Product { ProductName = "Freeze", Manufacturer = "Whitlpool", ShortCode = "fz", CostPrice = 15000, SellingPrice = 18000 });
            var product2 = (new Product { ProductName = "Fan", Manufacturer = "Usha", ShortCode = "fan", CostPrice = 1200, SellingPrice = 2000 });
            var product3 = (new Product { ProductName = "Pen", Manufacturer = "Cello", ShortCode = "pen", CostPrice = 12, SellingPrice = 20 });
            var product4 = (new Product { ProductName = "Shirt", Manufacturer = "Peter England", ShortCode = "shrt", CostPrice = 1200, SellingPrice = 2000 });
            var product5 = (new Product { ProductName = "Laptop", Manufacturer = "Lenovo", ShortCode = "lappi", CostPrice = 45000, SellingPrice = 55000 });
            var product6 = (new Product { ProductName = "Mobile", Manufacturer = "Oppo", ShortCode = "shrt", CostPrice = 1200, SellingPrice = 2000 });
            context.Product.AddRange(product, product1, product2, product3, product4, product5, product6);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void AddCategory()
        {
            var category = new Category { CategoryName = "Stationary" };
            var category1 = new Category { CategoryName = "Electronics" };
            var category2 = new Category { CategoryName = "Men Wears" };
            var category3 = new Category { CategoryName = "Chocolates" };
            context.Category.AddRange(category, category1, category1, category3);
            context.Add(category2);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        public static void AddProductCategory()
        {
            var productcategory = new ProductCategory { ProductId = 1, CategoryId = 3 };
            var productcategory1 = new ProductCategory { ProductId = 2, CategoryId = 1 };
            var productcategory2= new ProductCategory { ProductId = 3, CategoryId = 4 };
            var productcategory3 = new ProductCategory { ProductId = 4, CategoryId = 3 };
            var productcategory4 = new ProductCategory { ProductId = 5, CategoryId = 3 };
            var productcategory5 = new ProductCategory { ProductId = 6, CategoryId = 3};
            var productcategory6 = new ProductCategory { ProductId = 7, CategoryId = 3};
            context.Productcategory.AddRange(productcategory, productcategory1, productcategory2, productcategory3, productcategory4, productcategory5, productcategory6);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void AddInventory()
        {
            var inv1 = new Inventory { ProductId = 1, InStock=true ,ProductQuantity = 30 };
            var inv2 = new Inventory { ProductId = 1, InStock = true,  ProductQuantity = 20 };
            var inv3 = new Inventory { ProductId = 3, InStock = false, ProductQuantity = 0 };
            var inv4 = new Inventory { ProductId = 4, InStock = true, ProductQuantity = 40 };
            var inv5 = new Inventory { ProductId = 5, InStock = true, ProductQuantity = 15 };
            var inv6 = new Inventory { ProductId = 6, InStock = false, ProductQuantity = 0 };
            context.AddRange(inv1, inv2, inv3, inv4, inv5, inv6);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void AddSupplier()
        {
            var supplier1 = new Supplier { SupplierName = "Naman",PhoneNumber="9836345365",Email="naman@gmail.com",City="Ghaziabad",State="UttarPradesh"};
            var supplier2 = new Supplier { SupplierName = "Harshit",PhoneNumber="9836454554",Email="harshit@gmail.com",City="Firozabad",State="UttarPradesh"};
            var supplier3 = new Supplier { SupplierName = "Raju",PhoneNumber="7787878787",Email="raju@gmail.com",City="Noida",State="UttarPradesh"};
            var supplier4 = new Supplier { SupplierName = "Sunil",PhoneNumber="9982090909",Email="sunil@hgmail.com",City="Delhi",State="Delhi"};
            context.AddRange(supplier1, supplier2, supplier3, supplier4);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void AddProductSupplier()
        {
            var supplierproduct1 = new SupplierProduct { ProductId=1, SupplierId=1 };
            var supplierproduct2 = new SupplierProduct { ProductId=1, SupplierId=2 };
            var supplierproduct3 = new SupplierProduct { ProductId=2, SupplierId=1 };
            var supplierproduct4 = new SupplierProduct { ProductId=3, SupplierId=2 };
            var supplierproduct5 = new SupplierProduct { ProductId=4, SupplierId=4 };
            var supplierproduct6 = new SupplierProduct { ProductId=4, SupplierId=3 };
            context.AddRange(supplierproduct1, supplierproduct2, supplierproduct3, supplierproduct4, supplierproduct5, supplierproduct6);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

       
    }
}
