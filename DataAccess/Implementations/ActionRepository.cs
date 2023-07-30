namespace DataAccess.Implementations
{
    public class ActionRepository:BaseRepository<Entities.Action>
    {
        public ActionRepository(SheepControlDbContext context) : base(context)
        {
        }
    }
}
