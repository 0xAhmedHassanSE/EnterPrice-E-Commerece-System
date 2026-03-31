using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites.UserModule
{
    public class User
    {
        public int UserID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public virtual  Cart Cart { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public virtual ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
