using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class PhysicalSpecification
    {
        [Key]
        public int Id { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Ears { get; set; }
        public string Eyes { get; set; }
        public string Legs { get; set; }
        public string Tail { get; set; }
        public string Color { get; set; }
        public string Coat { get; set; }
        public int CatId { get; set; }
        public Cat Cat { get; set; }


    }
}
