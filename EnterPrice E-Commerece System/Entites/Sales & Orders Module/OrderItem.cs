

namespace EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module
{
    public class OrderItem
    {
        public int OrderID { get; set; }
        public int ProductVariantId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual ProductVariant ProductVariant { get; set; }
    }
}
