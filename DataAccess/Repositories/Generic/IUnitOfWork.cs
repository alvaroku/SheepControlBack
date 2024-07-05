namespace DataAccess.Repositories.Generic
{
    public interface IUnitOfWork:IDisposable
    {
        SheepControlDbContext Context { get; }
        void Commit();
    }
}
