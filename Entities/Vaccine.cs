using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vaccine:ObjetoBase
    {
        public int SheepId { get; set; }
        public Sheep Sheep { get; set;}
        public DateTime ApplicationDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Dosage { get; set; }
        public string Photo { get; set; }
    }
}
