namespace SheepControlApi.Entities.Dtos
{
    public class ObjetoBase
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool Active { get; set; } = true;

    }
}
