using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Shopee.Entities.Aggregates.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Infrastructure.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Id)
                .ValueGeneratedNever();

            builder.HasMany(product => product.CartItems)
                .WithOne(cartItem => cartItem.Product)
                .HasForeignKey(cartItem => cartItem.ProductId);

            builder.ToTable("Products");
        }
    }
}
