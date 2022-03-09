using System;
using Test_FrameworkCore_Console.EF;
using System.Linq;
using System.Collections.Generic;
using Test_FrameworkCore_Console.Entities;
using Microsoft.EntityFrameworkCore;

namespace Test_FrameworkCore_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new NameDbContext();

            
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
