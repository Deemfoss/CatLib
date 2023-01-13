using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CatLib.Models
{
    public class NewsDetailes
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string ShortDescription { get; set; }
        [AllowHtml]
        public string Content { get; set; }
   
    }
}
