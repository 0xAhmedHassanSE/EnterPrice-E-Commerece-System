using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Configrations.Sales___Orders_Configrations
{
    public class OrderItemConfigrations : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => new { oi.OrderID, oi.ProductVariantId });
            builder.HasOne(oi => oi.Order).WithMany(o => o.OrderItems);
            builder.HasOne(oi => oi.ProductVariant).WithMany(pv => pv.OrderItems)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(oi => oi.UnitPrice).HasColumnType("decimal(18,2)");
        }
    }
}
