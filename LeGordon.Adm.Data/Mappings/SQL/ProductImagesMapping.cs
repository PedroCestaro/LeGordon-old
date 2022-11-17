using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGordon.Adm.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGordon.Adm.Data.Mappings.SQL
{
    internal class ProductImagesMapping : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar").HasMaxLength(100);

            builder.Property(x => x.Url).IsRequired().HasColumnType("text");

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId);
        }
    }
}
