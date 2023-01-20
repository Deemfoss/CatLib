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
       public string Description { get; set; }

       public int ProductCategoryId { get; set; }
       public ProductCategory ProductCategory { get; set; }
    }
}
