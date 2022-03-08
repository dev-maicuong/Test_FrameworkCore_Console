using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_FrameworkCore_Console.Entities;
using Test_FrameworkCore_Console.EntityConfigurations;
using Test_FrameworkCore_Console.Extensions;

namespace Test_FrameworkCore_Console.EF
{
    public class NameDbContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<UserDetail> UserDetails { set; get; }
        public DbSet<UserRole> UserRoles { set; get; }
        public DbSet<Product> Products { set; get; }
        // Tạo ILoggerFactory 
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                   .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                   .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Debug)
                   .AddConsole();
        }
        );
        private const string connectionString = @"
                Server=DEV404\SQLEXPRESS;Database=TestQueryEFData;Trusted_Connection=True;";

        // Phương thức OnConfiguring gọi mỗi khi một đối tượng DbContext được tạo
        // Nạp chồng nó để thiết lập các cấu hình, như thiết lập chuỗi kết nối
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLoggerFactory(loggerFactory)
                .UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserDetailConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

    }
}
