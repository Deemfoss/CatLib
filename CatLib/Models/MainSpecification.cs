using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class MainSpecification
    {
        [Key]
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Color { get; set; }
        public string Life_Expectancy { get; set; }
        public string Litter_Size { get; set; }

        public int CatId { get; set; }
        public Cat Cat { get; set; }
    }
}
