using BDSA2019.Lecture10.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BDSA2019.Lecture10.Models
{
    public class SuperheroCreateDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string AlterEgo { get; set; }

        [StringLength(50)]
        public string Occupation { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        public Gender Gender { get; set; }
        
        public int? FirstAppearance { get; set; }

        [StringLength(250)]
        [Url]
        public string PortraitUrl { get; set; }

        [StringLength(250)]
        [Url]
        public string BackgroundUrl { get; set; }

        public ISet<string> Powers { get; set; } = new HashSet<string>();
    }
}
