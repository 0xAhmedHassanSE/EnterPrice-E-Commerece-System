using EnterPrice_E_Commerece_System.Entites.Inventory_Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Configrations.Inventory_Module_Configrations
{
    public class WarehouseConfigrations : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.HasData(
                new Warehouse { ID = 1, Name = "Main Warehouse - Cairo", Location = "5th Settlement, Industrial Zone" },
                new Warehouse { ID = 2, Name = "Logistics Center - Cairo", Location = "Nasr City, Makram Ebeid Ext." },
                new Warehouse { ID = 3, Name = "Sharqia Distribution Center", Location = "Zagazig, Belbeis Road" },
                new Warehouse { ID = 4, Name = "Alexandria Warehouse", Location = "Borg El Arab" },
                new Warehouse { ID = 5, Name = "Delta Warehouse", Location = "Mansoura" }
                );
        }
    }
}
