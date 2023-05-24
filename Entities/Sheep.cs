namespace Entities
{
    public class Sheep:ObjetoBase
    {
        public DateTime BirthDate {  get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
        public string Sex { get; set; }
        public string Photo { get; set; }
        public bool Sold { get; set; }
        public bool IsAcquisition { get; set; }
        //para cuando es adquisicion
        public float KiloPrice { get; set; }
        public float AcquisitionCost { get; set; }

    }
}
