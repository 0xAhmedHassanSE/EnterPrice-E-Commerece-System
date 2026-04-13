using EnterPrice_E_Commerece_System.Entites.Inventory_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Configrations.Inventory_Module_Configrations
{
    public class Inventory_Configrations : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(In => new { In.ProductVariantId, In.WarehouseId });
            builder.HasOne(In => In.ProductVariant).WithMany(pv => pv.Inventories)
                .HasForeignKey(In => In.ProductVariantId)
                .HasConstraintName("FK_Ineventory_ProductVarient")
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(In => In.Warehouse).WithMany(wh => wh.Inventories)
                .HasForeignKey(In => In.WarehouseId)
                .HasConstraintName("FK_Warehouse_Inventory")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(In => In.ReorderLevel).HasDefaultValue(10);
            builder.HasIndex(In => In.ProductVariantId);
            builder.HasIndex(In => In.WarehouseId);
            builder.Property(In => In.RowVersion).IsRowVersion();
            builder.ToTable(t => t.HasCheckConstraint("CK_Products_Quantity", "[QuantityAvailable] >= 0"));
        }
    }
}
