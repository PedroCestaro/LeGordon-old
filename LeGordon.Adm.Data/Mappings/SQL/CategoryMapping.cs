using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGordon.Adm.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGordon.Adm.Data.Mappings.SQL
{
    internal class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().HasAnnotation("SERIAL", 1);

            builder.Property(c => c.IsActive).HasColumnType("boolean").HasDefaultValue(true);

            builder.Property(c => c.Name).HasColumnType("varchar").HasMaxLength(100);

            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
