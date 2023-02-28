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
        public string Short_Description { get; set; }
        public string Other_Names { get; set; }
        public string Nicknames { get; set; }
        public string Kitty_Img { get; set; }

        public string Summary_desc{ get; set; }
        public string History_desc { get; set; }
        public string Persinality_desc { get; set; }
        public string Characteristics_desc { get; set; }
        public string Care_desc { get; set; }
        public string Color_desc { get; set; }
        public string Size_desc { get; set; }
        public string Health_desc { get; set; }
        public string Grooming_desc { get; set; }
        public string Price_desc { get; set; }
        public string Choosing_Kitten_desc { get; set; }
        public string Live_desc { get; set; }

        public int CatId { get; set; }
        public Cat Cat { get; set; }


    }
}
