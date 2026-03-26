using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites
{
    public class ProductVariant
    {
        public int ProductVariantID { get; set; }
        public int ProductID { get; set; }
        public string SKU { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public decimal PriceAdjustment { get; set; }
        public virtual Product Product { set; get; }
    }
}
