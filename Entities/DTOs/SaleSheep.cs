namespace Entities.DTOs
{
    public class SaleSheepResponse : ObjetoBase
    {
        public int SheepId { get; set; }
        public Sheep Sheep { get; set; }
        public float KiloPrice { get; set; }

        public float TotalCharged { get; set; }
        public float SaleProfit { get; set; }
        public DateTime SaleDate { get; set; }
    }
    public class SaleMultipleSheepRequest
    {
        public int[] SheepIds { get; set; }
        public float KiloPrice { get; set; }
        public float TotalCharged { get; set; }
        public float SaleProfit { get; set; }
        public DateTime SaleDate { get; set; }
    }
    public class SaleSheepRequest
    {
        public int SheepId { get; set; }
        public float KiloPrice { get; set; }
        public float TotalCharged { get; set; }
        public float SaleProfit { get; set; }
        public DateTime SaleDate { get; set; }
    }
    public class FilterSaleSheepRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
