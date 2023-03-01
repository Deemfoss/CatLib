using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Cat_Health
{
    public class Dosage
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int DiseaseID { get; set; }
        public Disease Disease { get; set; }
    }
}
