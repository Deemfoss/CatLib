using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Cat_Wariors_Generator
{
    public class WariorColor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int WariorColorId { get; set; }
        public WariorColor Color { get; set; }
        public List<WariorPrefix> WariorPrefix { get; set; } = new();
    }
}
