using System;
using Test_FrameworkCore_Console.EF;
using System.Linq;
using System.Collections.Generic;

namespace Test_FrameworkCore_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new NameDbContext();
            long id = 2;
            var result = db.Products.Find(id);
            Console.WriteLine($"name: {result.productName}");
            Console.ReadLine();

        }
    }
}
