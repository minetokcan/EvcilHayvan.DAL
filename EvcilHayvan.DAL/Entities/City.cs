using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class City
    {
        public City()
        {
            Counties = new HashSet<County>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<County> Counties { get; set; }
    }
}
