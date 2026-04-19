using EnterPrice_E_Commerece_System.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnterPrice_E_Commerece_System.Configrations.Catalog_Module_Configrations
{
    public class ProductVariantConfigraions : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.HasIndex(pv => pv.SKU, "IX_SKU").IsUnique();
            
        }
    }
}
