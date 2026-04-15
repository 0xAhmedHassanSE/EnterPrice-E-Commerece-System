using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EnterPrice_E_Commerece_System.Configrations.Sales___Orders_Configrations
{
    public class CartConfigrations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(c => c.User).WithOne(user => user.Cart).HasForeignKey<Cart>(c => c.UserID);
            builder.Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");

        }
    }
}
