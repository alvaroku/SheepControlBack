using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class VaccineResponse : ObjetoBase
    {
        public string Name { get; set; }
        public string Observations { get; set; }
        public string IndicatedDose { get; set; } // 1 ml | 12kg
        public string Photo { get; set; }
        public float NetContent { get; set; }
        public int Unities { get; set; }
        public float UnitPrice { get; set; }
        public float AcquisitionCost { get; set; }
    }
    public class VaccineRequest:ObjetoBase
    {
        public string Name { get; set; }
        public string Observations { get; set; }
        public string IndicatedDose { get; set; } // 1 ml | 12kg
        public string Photo { get; set; } = string.Empty;
        public float NetContent { get; set; }
        public int Unities { get; set; }
        public float UnitPrice { get; set; }
        public float AcquisitionCost { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
