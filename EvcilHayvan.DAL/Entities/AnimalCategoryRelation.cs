using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class AnimalCategoryRelation
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int AnimalCategoryId { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual AnimalCategory AnimalCategory { get; set; }
    }
}
