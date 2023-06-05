using Microsoft.AspNetCore.Http;
namespace Entities.DTOs
{
    public class VaccineResponse : ObjetoBase
    {
        public string Name { get; set; }
        public string Observations { get; set; }
        public string IndicatedDose { get; set; } // 1 ml | 12kg
        public string Photo { get; set; }
    }
    public class VaccineRequest:ObjetoBase
    {
        public string Name { get; set; }
        public string Observations { get; set; }
        public string IndicatedDose { get; set; } // 1 ml | 12kg
        public string Photo { get; set; } = string.Empty;
        public IFormFile? ImageFile { get; set; }
        public VaccineStockRequest VaccineStock { get; set; }
    }
    public class VaccineUpdateRequest : ObjetoBase
    {
        public string Name { get; set; }
        public string Observations { get; set; }
        public string IndicatedDose { get; set; } // 1 ml | 12kg
        public string Photo { get; set; } = string.Empty;
        public IFormFile? ImageFile { get; set; }
        //public VaccineStockResponse VaccineStock { get; set; }
    }
}
