using EnterPrice_E_Commerece_System.Configrations.Catalog_Module_Configrations;
using EnterPrice_E_Commerece_System.Configrations.Inventory_Module_Configrations;
using EnterPrice_E_Commerece_System.Configrations.Sales___Orders_Configrations;
using EnterPrice_E_Commerece_System.Configrations.UserModule;
using EnterPrice_E_Commerece_System.Entites;
using EnterPrice_E_Commerece_System.Entites.Inventory_Module;
using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using EnterPrice_E_Commerece_System.Entites.UserModule;
using Microsoft.EntityFrameworkCore;


namespace EnterPrice_E_Commerece_System.Data
{
    public class EnterPriseContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=.;Database=Enterprise;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Catalog Module
            modelBuilder.ApplyConfiguration(new ProductConfigrations());
            modelBuilder.ApplyConfiguration(new CategoryConfigrations());
            modelBuilder.ApplyConfiguration(new ProductVariantConfigraions());
            modelBuilder.ApplyConfiguration(new BrandConfigrations());
            //Inventory Module
            modelBuilder.ApplyConfiguration(new WarehouseConfigrations());
            modelBuilder.ApplyConfiguration(new Inventory_Configrations());
            //User Module
            modelBuilder.ApplyConfiguration(new Userconfigrations());
            modelBuilder.ApplyConfiguration(new UserRoleConfigrations());
            //Orders & Sales Module
            modelBuilder.ApplyConfiguration(new CartConfigrations());
            modelBuilder.ApplyConfiguration(new CartItemConfigrations());
            modelBuilder.ApplyConfiguration(new OrderConfigrations());
            modelBuilder.ApplyConfiguration(new OrderItemConfigrations());
            modelBuilder.ApplyConfiguration(new PaymentConfigrations());
            modelBuilder.ApplyConfiguration(new CouponConfigrations());
        }

        //Catalog Module
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        // Inventory Module
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        //User Module
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        //Orders & Sales Module
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
    }
}
