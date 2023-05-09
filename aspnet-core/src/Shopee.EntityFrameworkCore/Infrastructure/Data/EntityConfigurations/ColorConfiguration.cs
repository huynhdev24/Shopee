using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopee.Entities;

namespace Shopee.Infrastructure.Data.EntityConfigurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(color => color.Id);
            builder.Property(color => color.Id)
                .ValueGeneratedNever();

            builder.ToTable("Colors");
        }
    }
}
