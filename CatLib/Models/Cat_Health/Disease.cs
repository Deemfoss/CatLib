using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Cat_Health
{
    public class Disease
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string About { get; set; }
        public string Other_Names { get; set; }
        public string Symptoms { get; set; }
        public string Causes { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Prevention { get; set; }
        public string Living_Management { get; set; }

        public List<Disease_Question> Disease_Questions { get; set; } = new();

    }
}
