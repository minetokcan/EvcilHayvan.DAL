using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class Adoptation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AnimalId { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual User User { get; set; }
    }
}
