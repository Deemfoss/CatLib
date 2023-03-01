using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Products
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Summary { get; set; }
        public bool Toxic { get; set; }
        public bool Allergenic { get; set; }
        public bool Appropriate { get; set; }
        public string How_Much_to_Feed { get; set; }
        public string How_Often_to_Feed { get; set; }
        public int ProductCategoryId { get; set; }
        public string Nutrition_Stats { get; set; }
        public string Good_for_Cats { get; set; }
        public string Used_in_Commercial_Food { get; set; }
        public string Risks_for_Cats { get; set; }
        public string Nutritional_Benefits { get; set; }
        public string How_Much_to_Feed_description { get; set; }
        public string How_Offen_to_Feed_description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<ProductQuestion> ProductQuestions { get; set; } = new();
    }
}
