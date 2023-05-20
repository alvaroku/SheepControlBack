using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SaleSheepResponse : ObjetoBase
    {
        public int SheepId { get; set; }
        public Sheep Sheep { get; set; }
        public float KiloPrice { get; set; }

        public float TotalCharged { get; set; }
        public float SaleProfit { get; set; }
    }
    public class SaleSheepRequest
    {
        public int SheepId { get; set; }
        public float KiloPrice { get; set; }
        public float TotalCharged { get; set; }
        public float SaleProfit { get; set; }
    }
}
