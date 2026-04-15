using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnterPrice_E_Commerece_System.Configrations.Sales___Orders_Configrations
{
    public class CouponConfigrations : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasIndex(c => c.Code).IsUnique();
        }
    }
}
