using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VaccineStock:ObjetoBase
    {
        public DateTime AcquisitionDate { get; set; }
        public int VaccineId { get; set; }
        public Vaccine Vaccine { get; set; }
        public float NetContent { get; set; }
        public int Unities { get; set; }
        public float UnitPrice { get; set; }
        public float AcquisitionCost { get; set; }
    }
}
