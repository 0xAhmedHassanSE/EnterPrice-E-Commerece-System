using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string? TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsSuccessful { get; set; }
        public virtual Order Order { get; set; }
    }
}
