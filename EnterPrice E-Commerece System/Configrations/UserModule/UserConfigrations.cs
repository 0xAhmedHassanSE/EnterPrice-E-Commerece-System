using EnterPrice_E_Commerece_System.Entites.UserModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Configrations.UserModule
{
    public class Userconfigrations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(user => user.Roles).WithMany(role => role.Users);
            builder.HasMany(user => user.Addresses).WithOne(address => address.User)
                .HasForeignKey(address => address.UserID);
            builder.Property(user => user.IsActive).HasDefaultValue(true);
            builder.HasIndex(user => user.Email).IsUnique();
        }
    }
}
