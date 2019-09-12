﻿using System.Collections.Generic;

namespace BDSA2019.Lecture03.Models
{
    public class Superhero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string Occupation { get; set; }
        public int? CityId { get; set; }
        public Gender Gender { get; set; }
        public int FirstAppearance { get; set; }
        public ICollection<string> Powers { get; set; }
        public ICollection<Group> GroupAffiliations { get; set; }

        public override string ToString()
        {
            return $"{Name} aka {AlterEgo} ({FirstAppearance})";
        }
    }
}
