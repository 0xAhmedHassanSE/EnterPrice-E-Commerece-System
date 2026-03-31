using EnterPrice_E_Commerece_System.Entites.UserModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ShippingAddressId { get; set; }
        public int? CouponId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public virtual User User { get; set; }
        public virtual Address Address { get; set; }
        public virtual Coupon Coupon { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<OrderItem> OrderItems{ get; set; } = new HashSet<OrderItem>();
    }
}
