using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Coat { get; set; }
        public string Size { get; set; }
        public string Shedding { get; set; }
        public string Activity { get; set; }
        public string Playfulness { get; set; }
        public string Affection { get; set; }
        public string Intelligence { get; set; }
        public string Hypoallergenic { get; set; }
        public MainSpecification MainSpecification { get; set; }
        public OtherSpecification OtherSpecification { get; set; }
        public PhysicalSpecification PhysicalSpecification { get; set; }
        public TemperamentDescription TemperamentDescription { get; set; }
        public CompatibilityDescription CompatibilityDescription { get; set; }
        public List<Answer> Answers { get; set; } = new();

    }
}
