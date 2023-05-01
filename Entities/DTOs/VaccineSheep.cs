using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class VaccineSheepRequest : ObjetoBase
    {
        public int VaccineId { get; set; }
        public int SheepId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string DoseApplied { get; set; } // 1 ml|10kg
    }
    public class VaccineSheepResponse : ObjetoBase
    {
        public int VaccineId { get; set; }
        public Vaccine Vaccine { get; set; }

        public int SheepId { get; set; }
        public Sheep Sheep { get; set; }

        public DateTime ApplicationDate { get; set; }
        public string DoseApplied { get; set; } // 1 ml|10kg
    }
}
