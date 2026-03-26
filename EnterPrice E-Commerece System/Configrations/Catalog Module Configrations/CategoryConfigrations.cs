using EnterPrice_E_Commerece_System.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Configrations.Catalog_Module_Configrations
{
    public class CategoryConfigrations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(c => c.Categories).WithOne(c => c.ParentCategory).
                HasForeignKey(c => c.ParentCategoryId).
                HasConstraintName("FK_CategoryParent")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
                new Category { CategoryID = 1, Name = "Electronics", Description = "Modern devices and technologies", ParentCategoryId = null },
                new Category { CategoryID = 2, Name = "Mobiles & Tablets", Description = "Latest smartphones and tablets", ParentCategoryId = 1 },
                new Category { CategoryID = 3, Name = "Laptops & Computers", Description = "Computers and hardware equipment", ParentCategoryId = 1 },
                new Category { CategoryID = 4, Name = "Fashion & Clothing", Description = "Clothing for all ages", ParentCategoryId = null },
                new Category { CategoryID = 5, Name = "Men's Clothing", Description = "T-shirts, shirts, and pants", ParentCategoryId = 4 },
                new Category { CategoryID = 6, Name = "Sports Equipment", Description = "Gym equipment and sports apparel", ParentCategoryId = 4 },
                new Category { CategoryID = 7, Name = "Home Appliances", Description = "Refrigerators, washing machines, and TVs", ParentCategoryId = null },
                new Category { CategoryID = 8, Name = "Books & Publications", Description = "Novels, engineering, and computer science", ParentCategoryId = null }
                );
        }
    }
}
