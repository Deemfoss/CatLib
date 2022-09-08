using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class CatGeneratorType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CatGeneratorName> CatGeneratorNames { get; set; }

    }
}
