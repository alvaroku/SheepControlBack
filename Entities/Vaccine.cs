using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vaccine:ObjetoBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IndicatedDose { get; set; } // 1 ml | 12kg
        public string Photo { get; set; }
    }
}
