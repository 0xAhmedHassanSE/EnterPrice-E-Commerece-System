using EnterPrice_E_Commerece_System.Entites.UserModule;

namespace EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
