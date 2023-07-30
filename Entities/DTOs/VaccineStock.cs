using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class VaccineStockResponse:ObjetoBase
    {
        public DateTime AcquisitionDate { get; set; }
        public int VaccineId { get; set; }
        public VaccineResponse Vaccine { get; set; }
        public float NetContent { get; set; }
        public int Unities { get; set; }
        public float UnitPrice { get; set; }
        public float AcquisitionCost { get; set; }
    }
    public class VaccineStockRequest : ObjetoBase
    {
        public DateTime AcquisitionDate { get; set; }
        public int VaccineId { get; set; }
        public float NetContent { get; set; }
        public int Unities { get; set; }
        public float UnitPrice { get; set; }
        public float AcquisitionCost { get; set; }
    }
}
