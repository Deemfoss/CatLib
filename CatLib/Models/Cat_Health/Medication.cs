using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Models.Cat_Health
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string About { get; set; }
        public string Safe_For_Cats { get; set; }
        public string Side_Effects { get; set; }
        public string Overdose { get; set; }
        public string How_Much_Can_I_Give { get; set; }
        public string How_To_Give { get; set; }
        public string Use { get; set; }
        public List<Dosage> Dosages { get; set; } = new();
        public List<Medication_Question> Medication_Questions { get; set; } = new();
    }
}
