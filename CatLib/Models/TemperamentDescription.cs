using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class TemperamentDescription
    {
        [Key]
        public int Id { get; set; }

        public string Activity_Description { get; set; }
        public string Playfulness_Description { get; set; }
        public string Affection_Description { get; set; }
        public string Intelligence_Description { get; set; }

        public int CatId { get; set; }
        public Cat Cat { get; set; }
    }
}
