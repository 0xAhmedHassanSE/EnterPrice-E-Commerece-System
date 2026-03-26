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
                HasForeignKey( c=> c.ParentCategoryId).
                HasConstraintName("FK_CategoryParent")
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
