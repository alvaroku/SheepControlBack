
using Microsoft.AspNetCore.Http;

namespace Entities.DTOs
{
    public class SheepResponse : ObjetoBase
    {
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
        public string Sex { get; set; }
        public string Photo { get; set; }
    }
    public class SheepRequest : ObjetoBase
    {
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
        public string Sex { get; set; }
        public string Photo { get; set; } = "";
 
        public IFormFile ?ImageFile { get; set; }
    }
}
