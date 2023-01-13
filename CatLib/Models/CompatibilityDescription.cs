using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class CompatibilityDescription
    {   
        [Key]
        public int Id { get; set; }
        public string Friendliness_To_Dog_Description { get; set; }
        public string Friendliness_To_Cat_Description { get; set; }
        public string Friendliness_To_Old_Description { get; set; }
        public string Friendliness_To_Childern_Description { get; set; }
        public string Grooming_Description { get; set; }
        public string Vocality_Description { get; set; }
        public int CatId { get; set; }
        public Cat Cat { get; set; }
    }
}
