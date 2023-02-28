using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Cat_Health
{
    public class Disease_Question
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }
    }
}
