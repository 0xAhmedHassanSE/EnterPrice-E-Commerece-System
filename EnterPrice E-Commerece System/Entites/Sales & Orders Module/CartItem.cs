

namespace EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module
{
    public class CartItem
    {
        public int CartID { get; set; }
        public int ProudctVariantID { get; set; }
        public int Qunatity { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual ProductVariant ProductVariant { get; set; }
    }
}
