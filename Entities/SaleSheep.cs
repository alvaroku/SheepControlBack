namespace Entities
{
    public class SaleSheep:ObjetoBase
    {
        public int SheepId { get; set; }
        public Sheep Sheep { get; set; }
        public float KiloPrice { get; set; }

        public float TotalCharged { get; set; }
        public float SaleProfit { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
