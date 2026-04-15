

namespace EnterPrice_E_Commerece_System.Entites
{
    public class ProductImage
    {
        public int ProductImageID { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public virtual Product Product { get; set; }
    }
}
