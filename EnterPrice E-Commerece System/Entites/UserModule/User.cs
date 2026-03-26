using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites.UserModule
{
    public class User
    {
        public int USerID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();

        public virtual ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    }
}
