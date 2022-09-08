using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class CatGeneratorName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public string Hair { get; set; }  
        public string Activity { get; set; }
        public string Personality { get; set; }
        public List<CatGeneratorType> CatGeneratorTypes { get; set; }

    }
}
