using EnterPrice_E_Commerece_System.Entites.Inventory_Module;
using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;


namespace EnterPrice_E_Commerece_System.Entites
{
    public class ProductVariant
    {
        public int ProductVariantID { get; set; }
        public int ProductID { get; set; }
        public string SKU { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public decimal PriceAdjustment { get; set; }
        public virtual Product Product { set; get; }
        public virtual ICollection<Inventory> Inventories { get; set; } = new HashSet<Inventory>();
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
