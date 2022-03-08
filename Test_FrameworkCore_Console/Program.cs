using System;
using Test_FrameworkCore_Console.EF;
using System.Linq;
using System.Collections.Generic;
using Test_FrameworkCore_Console.Entities;

namespace Test_FrameworkCore_Console
{
    class Program
    {
        //List<Product> products = new List<Product>()
        //{
        //    new Product{ productName = "Sản phẩm 33",productId = 3},
        //    new Product{ productName = "Sản phẩm 44",productId = 4},
        //    new Product{ productName = "Sản phẩm 55",productId = 5},
        //};
        //db.Products.AddRange(products);
        //db.Products.RemoveRange(products);
        //var result = db.Products.FirstOrDefault(x=>x.productId == 1);
        static void Main(string[] args)
        {
            using var db = new NameDbContext();

            List<Product> products = db.Products.ToList();
            foreach(var item in products)
            {
                item.productName = "San pham update..";
            }
            var resultNumber = db.SaveChanges();

            Console.WriteLine($"result number : {resultNumber}");
            Console.ReadLine();

        }
    }
}
