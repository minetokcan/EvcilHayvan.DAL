using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class Address
    {
        public Address()
        {
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public int CountyId { get; set; }
        public string Title { get; set; }

        public virtual County County { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
