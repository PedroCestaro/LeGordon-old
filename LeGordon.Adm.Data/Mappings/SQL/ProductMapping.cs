using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using LeGordon.Adm.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGordon.Adm.Data.Mappings.SQL
{
    internal class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .IsRequired();

            builder.Property(p => p.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(250);

            builder.Property(p => p.Description)
                   .HasColumnType("text")
                   .HasMaxLength(500);

            builder.Property(p => p.IsActive)
                .HasColumnType("boolean");

            builder.Property(p => p.Price)
                .HasColumnType("decimal(2,3)");

            builder.HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
