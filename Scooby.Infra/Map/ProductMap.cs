using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scooby.Domain.Entity;

namespace Scooby.Infra.Map
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Description).HasMaxLength(150).HasColumnType("varchar(150)");
            builder.Property(x => x.Price).IsRequired().HasColumnType("money");
            builder.Property(x => x.Stock).IsRequired().HasColumnType("int");
            builder.Property(x => x.Image).HasMaxLength(255).HasColumnType("nvarchar(255)");
            builder.Property(x => x.CreateAt).IsRequired().HasColumnType("datetime");
            builder.HasOne(x => x.Brand);
            builder.HasOne(x => x.Family);
            builder.HasOne(x => x.Category);
        }

    }
}
