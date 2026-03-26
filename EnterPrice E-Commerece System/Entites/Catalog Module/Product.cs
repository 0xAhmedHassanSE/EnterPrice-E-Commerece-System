using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal BasePrice { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new HashSet<ProductVariant>();
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();

    }
}
