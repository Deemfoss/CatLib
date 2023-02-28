using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Products
{
    public class ProductQuestion
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
