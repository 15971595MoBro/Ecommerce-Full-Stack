using Ecommerce.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Data.Config
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x=> x.Name).IsRequired();
            builder.Property(x=> x.Description).IsRequired();
            builder.Property(x=> x.NewPrice).HasColumnType("decimal(18,2)");
            builder.HasData(
                new Product { Id = 1, Name = "Test Product", Description = "This is a test product", NewPrice = 20, CategoryId = 1 }
                );
        }
    }
}
