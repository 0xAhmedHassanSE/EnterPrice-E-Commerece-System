using EnterPrice_E_Commerece_System.Data;
using EnterPrice_E_Commerece_System.Entites;
using EnterPrice_E_Commerece_System.Entites.Inventory_Module;
using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using EnterPrice_E_Commerece_System.Entites.UserModule;

namespace EnterPrice_E_Commerece_System.CRUD
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EnterPriseContext context;

        public UnitOfWork(EnterPriseContext enterPrise)
        {
            context = enterPrise ?? throw new ArgumentNullException(nameof(enterPrise),
                "Database context cannot be null");
        }
        //User Module
        IGenericRepository<User> users;
        public IGenericRepository<User> Users => users ??= new GenericRepository<User>(context);

        IGenericRepository<Role> roles;
        public IGenericRepository<Role> Roles => roles ??= new GenericRepository<Role>(context);

        IGenericRepository<UserRole> userRoles;
        public IGenericRepository<UserRole> UserRoles => userRoles ??= new GenericRepository<UserRole>(context);

        IGenericRepository<Address> addresses;
        public IGenericRepository<Address> Addresses => addresses ??= new GenericRepository<Address>(context);

        // Catalog Module
        IGenericRepository<Category> categories;
        public IGenericRepository<Category> Categories => categories ??= new GenericRepository<Category>(context);

        IGenericRepository<Brand> brands;
        public IGenericRepository<Brand> Brands => brands ??= new GenericRepository<Brand>(context);

        IGenericRepository<Product> products;
        public IGenericRepository<Product> Products => products ??= new GenericRepository<Product>(context);

        IGenericRepository<ProductImage> productImages;
        public IGenericRepository<ProductImage> ProductImages => productImages ??= new GenericRepository<ProductImage>(context);

        IGenericRepository<ProductVariant> productVariants;
        public IGenericRepository<ProductVariant> ProductVariants => productVariants ??= new GenericRepository<ProductVariant>(context);

        //Inventory Module

        IGenericRepository<Inventory> inventories;
        public IGenericRepository<Inventory> Inventories => inventories ??= new GenericRepository<Inventory>(context);

        IGenericRepository<Warehouse> warhouses;
        public IGenericRepository<Warehouse> Warhouses => warhouses ??= new GenericRepository<Warehouse>(context);

        IGenericRepository<Supplier> supplieres;
        public IGenericRepository<Supplier> Supplieres => supplieres ??= new GenericRepository<Supplier>(context);

        //Orders Module

        IGenericRepository<Order> orders;
        public IGenericRepository<Order> Orders => new GenericRepository<Order>(context);

        IGenericRepository<Cart> carts;
        public IGenericRepository<Cart> Carts => carts ??= new GenericRepository<Cart>(context);

        IGenericRepository<CartItem> cartItems;
        public IGenericRepository<CartItem> CartItems => cartItems ??= new GenericRepository<CartItem>(context);

        IGenericRepository<Coupon> coupons;
        public IGenericRepository<Coupon> Coupons => coupons ??= new GenericRepository<Coupon>(context);

        IGenericRepository<OrderItem> orderItems;
        public IGenericRepository<OrderItem> OrderItems => orderItems ??= new GenericRepository<OrderItem>(context);

        IGenericRepository<Payment> payments;
        public IGenericRepository<Payment> Payments => payments ??= new GenericRepository<Payment>(context);


        public async Task<int> CompleteAsync() => await context.SaveChangesAsync();
        public async ValueTask DisposeAsync() => await context.DisposeAsync();

        public void ClearTracking() => context.ChangeTracker.Clear();

    }
}
