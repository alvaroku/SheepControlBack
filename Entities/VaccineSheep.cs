namespace Entities
{
    public class VaccineSheep:ObjetoBase
    {
        public int VaccineId { get; set; }
        public Vaccine Vaccine { get; set; }

        public int SheepId { get; set; }
        public Sheep Sheep { get; set;}

        public DateTime ApplicationDate {  get; set; }
        public string DoseApplied { get; set; } // 1 ml|10kg
    }
}
