using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class OtherSpecification
    {
        public int Id { get; set; }
        public int Playfulness{ get; set; }
        public int Activity { get; set; }
        public int Friendliness_To_Pets { get; set; }
        public int Friendliness_To_Childern { get; set; }
        public int Grooming { get; set; }
        public int Vocality { get; set; }
        public int Affection { get; set; }
        public int Docility { get; set; }
        public int Intelligence { get; set; }
        public int Independence { get; set; }
        public int Hardiness { get; set; }
        public int CatId { get; set; }
        public Cat Cat { get; set; }


    }
}
