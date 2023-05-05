using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FilterVaccineSheepRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int? SheepId { get; set; }
        public int? VaccineId { get; set; }
    }
}
