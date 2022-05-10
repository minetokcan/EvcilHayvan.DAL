using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class User
    {
        public User()
        {
            Adoptations = new HashSet<Adoptation>();
            UserAddresses = new HashSet<UserAddress>();
            UserRoleManagements = new HashSet<UserRoleManagement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Adoptation> Adoptations { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserRoleManagement> UserRoleManagements { get; set; }
    }
}
