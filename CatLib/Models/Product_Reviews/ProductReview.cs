using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Product_Reviews
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string Price { get; set; }
        public string Link { get; set; }
        public ProductArticle ProductArticle { get; set; }
    }

}
