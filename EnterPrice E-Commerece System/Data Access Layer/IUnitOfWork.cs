using EnterPrice_E_Commerece_System.Entites;
using EnterPrice_E_Commerece_System.Entites.Inventory_Module;
using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using EnterPrice_E_Commerece_System.Entites.UserModule;

namespace EnterPrice_E_Commerece_System.CRUD
{
    public interface IUnitOfWork : IAsyncDisposable
    {

        //User Module
        public IGenericRepository<User> Users { get; }
        public IGenericRepository<Role> Roles { get; }
        public IGenericRepository<UserRole> UserRoles { get; }
        public IGenericRepository<Address> Addresses { get; }
        //Catalog Module
        public IGenericRepository<Category> Categories { get; }
        public IGenericRepository<Brand> Brands { get; }
        public IGenericRepository<Product> Products { get; }
        public IGenericRepository<ProductImage> ProductImages { get; }
        public IGenericRepository<ProductVariant> ProductVariants { get; }
        //Inventory Module
        public IGenericRepository<Inventory> Inventories { get; }
        public IGenericRepository<Warehouse> Warhouses { get; }
        public IGenericRepository<Supplier> Supplieres { get; }
        //Sales & Orders Module
        public IGenericRepository<Order> Orders { get; }
        public IGenericRepository<Cart> Carts { get; }
        public IGenericRepository<CartItem> CartItems { get; }
        public IGenericRepository<Coupon> Coupons { get; }
        public IGenericRepository<OrderItem> OrderItems { get; }
        public IGenericRepository<Payment> Payments { get; }

        Task<int> CompleteAsync();
        void ClearTracking();

    }
}
