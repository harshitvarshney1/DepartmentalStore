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
            //Console.WriteLine("1st Query");
            //Console.WriteLine("Query Staff using Name");
            //SelectQueries.QueryStaffUsingName();
            //Console.WriteLine("\nQuery Staff using Phone Number");
            //SelectQueries.QueryStaffUsingPhoneNumber();
            //Console.WriteLine("2nd Query");
            //Console.WriteLine("\nQuery Staff using  thier Role");
            //SelectQueries.QueryStaffUsingRole();
            //Console.WriteLine("3rd Query");
            //Console.WriteLine("\nQuery Product using Name");
            //SelectQueries.QueryProductUsingName();
            //Console.WriteLine("Query Product based on Category");
            //SelectQueries.QueryProduct();
            //Console.WriteLine("Query Product Based on Instock");
            //SelectQueries.QueryProductBasedOnOutstock();
            //Console.WriteLine("Query Product Based on Selling Price");
            //SelectQueries.QueryProductBasedOnSellingPrice();
            //Console.WriteLine("4th query");
            //SelectQueries.NumberOfProductOutOfStock();
            // Console.WriteLine("5th Query");
            //Console.WriteLine("Number of product Within a category");
            //SelectQueries.NumberofProductswithinacategory();
            Console.WriteLine("6th Query");
            Console.WriteLine("Product-Categories listed in descending with highest number of products to the lowest number of products");
            SelectQueries.QueryProductBasedOnHighestToLowest();
            //Console.WriteLine("7th Query");
            //Console.WriteLine("\n List of supplier");
            //SelectQueries.ListOfSuppliers();
           



        }









    }
}

