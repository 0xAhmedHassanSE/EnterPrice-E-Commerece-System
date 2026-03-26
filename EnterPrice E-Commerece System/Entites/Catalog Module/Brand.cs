using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
        public string? LogoUrl { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
