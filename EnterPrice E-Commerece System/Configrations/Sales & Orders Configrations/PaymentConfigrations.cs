using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnterPrice_E_Commerece_System.Configrations.Sales___Orders_Configrations
{
    public class PaymentConfigrations : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasOne(p => p.Order).WithOne(o => o.Payment)
                .HasForeignKey<Payment>(p => p.OrderId).OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.PaymentMethod).HasConversion<string>();
        }
    }
}
