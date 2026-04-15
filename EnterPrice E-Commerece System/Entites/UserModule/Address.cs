using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;


namespace EnterPrice_E_Commerece_System.Entites.UserModule
{
    public class Address
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool IsDefault { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
