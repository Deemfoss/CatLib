using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int CatId { get; set; }
        public Cat Cat { get; set; }

    }
}
