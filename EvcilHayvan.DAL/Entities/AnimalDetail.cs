using System;
using System.Collections.Generic;

#nullable disable

namespace EvcilHayvan.DAL.Entities
{
    public partial class AnimalDetail
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public string Breed { get; set; }
        public bool? IsVaccinated { get; set; }
        public bool? IsAnimalHomeless { get; set; }
        public string Details { get; set; }

        public virtual Animal Animal { get; set; }
    }
}
