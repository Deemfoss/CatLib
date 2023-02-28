using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.NameGenerator
{
    public class Personality
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desctiption { get; set; }
        public string Img { get; set; }
        public int CategoryNameId { get; set; }
        public CategoryName CategoryName { get; set; }
        public List<CatGeneratorName> CatGeneratorNames { get; set; } = new();
        public bool IsCharacter { get; set; }
    }
}
