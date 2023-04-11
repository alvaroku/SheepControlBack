using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sheep:ObjetoBase
    {
        public DateTime BirthDate {  get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
        public EnumSex Sex { get; set; }
        public string Photo { get; set; }
        public IEnumerable<Vaccine> Vaccine { get; set; } = new List<Vaccine>();
    }
}
