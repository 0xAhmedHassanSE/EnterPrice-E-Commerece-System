using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnterPrice_E_Commerece_System.Configrations.Sales___Orders_Configrations
{
    public class CartItemConfigrations : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(ci => new { ci.ProudctVariantID, ci.CartID });
            builder.HasOne(ci => ci.ProductVariant).WithMany(pv => pv.CartItems).HasForeignKey(ci => ci.ProudctVariantID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(ci => ci.Cart).WithMany(C => C.CartItems).HasForeignKey(ci => ci.CartID);
        }
    }
}
