namespace DataAccess.Repositories.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        public SheepControlDbContext Context { get;}

        public UnitOfWork(SheepControlDbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
           Context.Dispose();
        }
    }
}
