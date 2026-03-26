using EnterPrice_E_Commerece_System.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Configrations.Catalog_Module_Configrations
{
    public class BrandConfigrations : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { BrandID = 1, Name = "Samsung", LogoUrl = "/images/brands/samsung.png" },
                new Brand { BrandID = 2, Name = "Apple", LogoUrl = "/images/brands/apple.png" },
                new Brand { BrandID = 3, Name = "Dell", LogoUrl = "/images/brands/dell.png" },
                new Brand { BrandID = 4, Name = "HP", LogoUrl = "/images/brands/hp.png" },
                new Brand { BrandID = 5, Name = "Nike", LogoUrl = "/images/brands/nike.png" },
                new Brand { BrandID = 6, Name = "Adidas", LogoUrl = "/images/brands/adidas.png" },
                new Brand { BrandID = 7, Name = "LG", LogoUrl = "/images/brands/lg.png" },
                new Brand { BrandID = 8, Name = "Zara", LogoUrl = "/images/brands/zara.png" }
                );
        }
    }
}
