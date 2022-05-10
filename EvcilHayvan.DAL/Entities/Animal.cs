using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class Animal
    {
        public Animal()
        {
            Adoptations = new HashSet<Adoptation>();
            AnimalCategoryRelations = new HashSet<AnimalCategoryRelation>();
            AnimalDetails = new HashSet<AnimalDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Adoptation> Adoptations { get; set; }
        public virtual ICollection<AnimalCategoryRelation> AnimalCategoryRelations { get; set; }
        public virtual ICollection<AnimalDetail> AnimalDetails { get; set; }
    }
}
