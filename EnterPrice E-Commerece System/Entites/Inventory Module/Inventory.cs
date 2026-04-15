
namespace EnterPrice_E_Commerece_System.Entites.Inventory_Module
{
    public class Inventory
    {
        public int ProductVariantId { get; set; }
        public int WarehouseId { get; set; }
        public int QuantityAvailable { get; set; }
        public int? ReorderLevel { get; set; }
        public byte[] RowVersion { get; set; }


        public virtual ProductVariant ProductVariant{ get; set; }
        public virtual Warehouse Warehouse { get; set; }

    }
}
