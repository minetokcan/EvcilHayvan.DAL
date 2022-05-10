﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class UserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
    }
}
