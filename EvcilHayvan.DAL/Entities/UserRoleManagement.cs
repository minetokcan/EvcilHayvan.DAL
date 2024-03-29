﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class UserRoleManagement
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
