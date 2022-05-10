using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class Role
    {
        public Role()
        {
            UserRoleManagements = new HashSet<UserRoleManagement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short Status { get; set; }

        public virtual ICollection<UserRoleManagement> UserRoleManagements { get; set; }
    }
}
