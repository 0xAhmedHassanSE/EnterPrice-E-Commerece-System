using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EnterPrice_E_Commerece_System.Configrations.Sales___Orders_Configrations
{
    public class OrderConfigrations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o => o.User).WithMany(user => user.Orders).HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Address).WithMany(A => A.Orders).HasForeignKey(o => o.ShippingAddressId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Coupon).WithMany(c => c.Orders).HasForeignKey(o => o.CouponId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Property(o => o.Status).HasConversion<string>();
            builder.Property(o => o.TotalAmount).HasColumnType("decimal(18,2)");
        }
    }
}
