using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class OtherSpecification
    {
        public int Id { get; set; }
        public string Friendliness_To_Dog { get; set; }
        public string Friendliness_To_Cat { get; set; }
        public string Friendliness_To_Old { get; set; }
        public string Friendliness_To_Childern { get; set; }
        public string Grooming { get; set; }
        public string Vocality { get; set; }
        public string Choosing_Kitten { get; set; }
        public string Health { get; set; }
        public string Care_Maintenance { get; set; }

        public string Short_Description { get; set; }
        public string Other_Names { get; set; }
        public string Nicknames { get; set; }

        public string Kitty_Img { get; set; }

        public int CatId { get; set; }
        public Cat Cat { get; set; }


    }
}
