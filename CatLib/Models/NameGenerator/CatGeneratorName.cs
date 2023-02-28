using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.NameGenerator
{
    public class CatGeneratorName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int HairId { get; set; }
        public Hair Hair { get; set; }
        public List<Personality> Personalities { get; set; } = new();
        public string Description { get; set; }
        public List<CatGeneratorType> CatGeneratorTypes { get; set; }

    }
}
