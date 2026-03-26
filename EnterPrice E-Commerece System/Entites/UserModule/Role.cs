using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.Entites.UserModule
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
