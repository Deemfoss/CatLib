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
        public string Name { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public string Grooming { get; set; }
        public string Exercise { get; set; }
        public string Health { get; set; }

        public MainSpecification MainSpecification { get; set; }
        public OtherSpecification OtherSpecification { get; set; }
        public PhysicalSpecification PhysicalSpecification { get; set; }

    }
}
