

namespace EnterPrice_E_Commerece_System.Entites
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public virtual Category ParentCategory { set; get; }
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}
