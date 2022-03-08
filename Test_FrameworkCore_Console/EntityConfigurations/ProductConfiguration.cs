using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_FrameworkCore_Console.Entities;

namespace Test_FrameworkCore_Console.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.productId);
            builder.HasOne(x => x.user).WithMany(x => x.products).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
