using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaleSheep:ObjetoBase
    {
        public int SheepId { get; set; }
        public Sheep Sheep { get; set; }
        public float KiloPrice { get; set; }

        public float TotalCharged { get; set; }
        public float SaleProfit { get; set; }
    }
}
