namespace DataAccess.Repositories.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        public SheepControlDbContext Context { get;}

        public UnitOfWork(SheepControlDbContext context)
        {
            Context = context;
        }

        public async Task Commit()
        {
            await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
           Context.Dispose();
        }
    }
}
