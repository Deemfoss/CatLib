using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Product_Reviews
{
    public class ProductArticle
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public List<ProductReview> ProductReviews { get; set; } = new();
    }
}
