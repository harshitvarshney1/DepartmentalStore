using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepartmentalStore.Data;
using DepartmentalStore.Domain;
namespace DepartmentalStore
{
    public class SelectQueries
    {
        public static DepartmentStoreContext context = new DepartmentStoreContext();
        public static void QueryStaffUsingName()
        {           
            var data = context.Staff.Where(x => x.FirstName == "Prerna").ToList();       
            foreach(var da in data)
            {
                Console.WriteLine(da.Id + " " + da.FirstName + " " + da.LastName + " " + da.PhoneNumber + " " + da.Gender + " " + da.Salary + " " + da.RoleId + " " + da.AddressId);
            }
        }
        public static void QueryStaffUsingPhoneNumber()
        {       
            var data = context.Staff.Where(x => x.PhoneNumber == "9873330556").ToList();
            foreach (var da in data)
            {
                Console.WriteLine(da.Id + " " + da.FirstName + " " + da.LastName + " " + da.PhoneNumber + " " + da.Gender + " " + da.Salary + " " + da.RoleId + " " + da.AddressId);
            }          
        }

        public static void QueryStaffUsingRole()
        {
            var data = context.Staff.Where(x => x.RoleId == 1).ToList();
            foreach (var da in data)
            {
                Console.WriteLine(da.Id + " " + da.FirstName + " " + da.LastName + " " + da.PhoneNumber + " " + da.Gender + " " + da.Salary + " " + da.RoleId + " " + da.AddressId);
            }
        }
        public static void QueryProductUsingName()
        {
            var products = context.Product.Where(x => x.ProductName == "Tv").ToList();
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.Manufacturer + " " + product.ShortCode + " " + product.CostPrice + " " +product.SellingPrice);
            }
        }

        public static void QueryProductBasedOnOutstock()
        {
            var pis = (from p in context.Product
                       join i in context.Inventory on p.ProductId equals i.ProductId
                       where i.InStock == false
                       select p).ToList();
           
            foreach (var product in pis)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName);
            }
        }

        public static void QueryProductBasedOnSellingPrice()
        {
            Console.WriteLine("Greater Than");
            var data = context.Product.Where(x => x.SellingPrice > 1000).ToList();
            foreach (var product in data)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.Manufacturer + " " + product.ShortCode + " " + product.CostPrice + " " + product.SellingPrice);
            }
            Console.WriteLine("Less Than");
            var data1 = context.Product.Where(x => x.SellingPrice < 1000).ToList();
            foreach (var product in data1)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.Manufacturer + " " + product.ShortCode + " " + product.CostPrice + " " + product.SellingPrice);
            }

            Console.WriteLine("between");
            var data2 = context.Product.Where(x => x.SellingPrice > 9000 && x.SellingPrice<20000).ToList();
            foreach (var product in data2)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.Manufacturer + " " + product.ShortCode + " " + product.CostPrice + " " + product.SellingPrice);
            }
        }



        public static void NumberOfProductOutOfStock()
        {
            var pis = (from p in context.Product
                      join i in context.Inventory on p.ProductId equals i.ProductId
                      where i.InStock==false
                      select p).Count();
            Console.WriteLine("Number of product Out of stock: "+pis);
           
        }

        public static void QueryProduct()
        {
            //var productbycategory = from p in context.Product
            //                        join pc in context.Productcategory on p.ProductId equals pc.ProductId
            //                        join cat in context.Category on pc.CategoryId equals cat.CategoryId
            //                        select new { p.ProductName, cat.CategoryName };


            //foreach (var val in productbycategory)
            //{
            //    Console.WriteLine("Product Name: {0} \t Category Name: {1}", val.ProductName, val.CategoryName);
            //}
            Console.WriteLine("Query2 : Query on Staff - using Department");
            var res = context.Product.Join(context.Category,
                             e1 => e1.ProductId,
                             e3 => e3.CategoryId,
                             (e1, e3) => new {
                                 name = e1.ProductName,
                                 cat = e3.CategoryName
                             });
            Console.WriteLine("Name" + "\t\t" + "DepartmentName \n");
            foreach (var i in res)
            {
                Console.WriteLine($"{i.name} \t\t {i.cat}");
            }
        }
        public static void ListOfSuppliers()
        {
            Console.WriteLine("By Name");
            var suppliers = context.Supplier.Where(x => x.SupplierName == "Sunil");
            foreach(var supplier in suppliers)
            {
                Console.WriteLine(supplier.SupplierId + " " + supplier.SupplierName);
            }
            Console.WriteLine("Phone Number");
            var suppliers1 = context.Supplier.Where(x => x.PhoneNumber == "9836345365");
            foreach (var supplier in suppliers1)
            {
                Console.WriteLine(supplier.SupplierId + " " + supplier.SupplierName);
            }
            Console.WriteLine("Email Address");
            var suppliers2 = context.Supplier.Where(x => x.Email == "raju@gmail.com");
            foreach (var supplier in suppliers2)
            {
                Console.WriteLine(supplier.SupplierId + " " + supplier.SupplierName);
            }
            Console.WriteLine("City");
            var suppliers3 = context.Supplier.Where(x => x.City=="Ghaziabad");
            foreach (var supplier in suppliers3)
            {
                Console.WriteLine(supplier.SupplierId + " " + supplier.SupplierName);
            }
            Console.WriteLine("State");
            var suppliers4 = context.Supplier.Where(x => x.State == "UttarPradesh");
            foreach (var supplier in suppliers4)
            {
                Console.WriteLine(supplier.SupplierId + " " + supplier.SupplierName);
            }
        }

        //public static void QueryProductUsingCategory()
        //{
        //    var pcs = from s in context.Product
        //              join c in context.Category on s.ProductId equals c.CategoryId
        //              where c.CategoryName == "Electronics"
        //              select s;

        //    foreach (var pc in pcs)
        //    {
        //        Console.WriteLine(pc.ProductId);
        //    }
        //}

        public static void NumberofProductswithinacategory()
        {
            var result = (from p in context.Category
                          join c in context.Productcategory
                          on p.CategoryId equals c.CategoryId
                          group p by c.CategoryId into x
                          select new
                          {
                              Count = x.Count<Category>(),
                              Category_Id = x.Key
                          }).ToList();
            foreach (var i in result)
            {
                Console.WriteLine("Category_ID : " + i.Category_Id +" " + "Count: " + i.Count);
                
            }
        }

        
    }
}
