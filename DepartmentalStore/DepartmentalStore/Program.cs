using DepartmentalStore.Data;
using DepartmentalStore.Domain;
using System;
using System.Collections.Generic;

namespace DepartmentalStore
{
    public class Program
    {
        public static DepartmentStoreContext context = new DepartmentStoreContext();
        public static void Main(string[] args)
        {
            //AddOperations.AddRole();
            //AddOperations.AddAddress();
            //AddOperations.AddStaff();
            //AddOperations.AddProduct();
            //AddOperations.AddCategory();
            //AddOperations.AddProductCategory();
            //AddOperations.AddInventory();
            //AddOperations.AddSupplier();
            //AddOperations.AddProductSupplier();
            Console.WriteLine("Query Staff using Name");
            SelectQueries.QueryStaffUsingName();
            Console.WriteLine("\nQuery Staff using Phone Number");
            SelectQueries.QueryStaffUsingPhoneNumber();
            Console.WriteLine("\nQuery Staff using  thier Role");
            SelectQueries.QueryStaffUsingRole();
            Console.WriteLine("\nQuery Product using Name");
            SelectQueries.QueryProductUsingName();


            SelectQueries.NumberOfProductOutOfStock();
            Console.WriteLine("\n List of supplier");
            SelectQueries.ListOfSuppliers();

            SelectQueries.QueryProduct();
            Console.WriteLine("Number of product Within a category");
            SelectQueries.NumberofProductswithinacategory();
            Console.WriteLine("Query Product Based on Instock");
            SelectQueries.QueryProductBasedOnOutstock();
            Console.WriteLine("Query Product Based on Selling Price");
            SelectQueries.QueryProductBasedOnSellingPrice();
        }









    }
}

