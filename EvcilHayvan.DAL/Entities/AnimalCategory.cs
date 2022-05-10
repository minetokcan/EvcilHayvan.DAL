using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class AnimalCategory
    {
        public AnimalCategory()
        {
            AnimalCategoryRelations = new HashSet<AnimalCategoryRelation>();
        }

        public int Id { get; set; }
        public string CategotyName { get; set; }
        public short Status { get; set; }

        public virtual ICollection<AnimalCategoryRelation> AnimalCategoryRelations { get; set; }
    }
}
