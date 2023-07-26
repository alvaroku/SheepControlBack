using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SheepHistoricWeight : ObjetoBase
    {
        public int SheepId { get; set; }
        public Sheep Sheep { get; set; }    //diferencia = nuevo peso - prev
        //public float PreviousWeight { get; set; }
        public float NewWeight { get; set; }
        //public float DifferenceWithPreviousWeight { get; set; }
        public DateTime WeighingDate { get; set; }
    }
}
