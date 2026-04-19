
namespace EnterPrice_E_Commerece_System.Entites.Inventory_Module
{
    public class Warehouse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; } = new HashSet<Inventory>();

    }
}
