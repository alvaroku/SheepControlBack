using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SheepHistoricWeightResponse : ObjetoBase
    {
        public int SheepId { get; set; }
        public Sheep Sheep { get; set; }    //diferencia = nuevo peso - prev
        public float NewWeight { get; set; }
        public DateTime WeighingDate { get;set; }
    }
    public class SheepHistoricWeightRequest : ObjetoBase
    {
        public int SheepId { get; set; }
        public float NewWeight { get; set; }
        public DateTime WeighingDate { get; set; }
        //public float DifferenceWithPrevWeight { get; set; }
    }
}
