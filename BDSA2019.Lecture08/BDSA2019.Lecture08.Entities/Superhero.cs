using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BDSA2019.Lecture08.Entities
{
    public class Superhero
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string AlterEgo { get; set; }

        [StringLength(50)]
        public string Occupation { get; set; }

        public int? CityId { get; set; }

        public City City { get; set; }
        
        public Gender Gender { get; set; }

        public int? FirstAppearance { get; set; }
        
        public ICollection<SuperheroPower> Powers { get; set; }
    }
}
