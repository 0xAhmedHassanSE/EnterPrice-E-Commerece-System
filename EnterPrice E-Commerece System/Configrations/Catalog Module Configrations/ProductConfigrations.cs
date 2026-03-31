using EnterPrice_E_Commerece_System.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Configrations.Catalog_Module_Configrations
{
    public class ProductConfigrations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p => p.Category).WithMany(c => c.Products).
                HasForeignKey(p => p.CategoryID).
                HasConstraintName("FK_Product_Category").
                OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Brand).WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.ProductVariants).WithOne(pv => pv.Product).
                HasForeignKey(pv => pv.ProductID).
                HasConstraintName("FK_Product_VarientProduct")
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.ProductImages).WithOne(pi => pi.Product).
                HasForeignKey(pi => pi.ProductId).
                HasConstraintName("FK_Product_ProductImage").
                OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(p => p.BrandID, "IX_BrandID");
            builder.HasIndex(p => p.CategoryID, "IX_CategoryID");
            builder.HasIndex(p => p.Name, "IX_ProductName");
            builder.HasQueryFilter(p => !p.IsDeleted);
            builder.Property(p => p.BasePrice).HasColumnType("decimal(18,2)");

        }
    }
}
