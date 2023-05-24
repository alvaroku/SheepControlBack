using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class BaseRepository<T> where T : class
    {
        public SheepControlDbContext _context;
        public DbSet<T> _dbSet;

        public BaseRepository(SheepControlDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }
        public void Create(T Data)
        {
            _dbSet.Add(Data);
            _context.SaveChanges();
        }
        public void CreateRange(IEnumerable<T> Data)
        {
            _dbSet.AddRange(Data);
            _context.SaveChanges();
        }
        public IEnumerable<T> Read()
        {
            return _dbSet.ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Update(T Data)
        {
            _dbSet.Update(Data);
            _context.SaveChanges();
        }
        public void UpdateRange(IEnumerable<T> data)
        {
            _dbSet.UpdateRange(data);
            _context.SaveChanges();
        }
        public void Delete(T Data)
        {
            _dbSet.Remove(Data);
            _context.SaveChanges();
            try
            {
                string table = _dbSet.EntityType.Name.Split(".")[1];
                string sp = $"ResetId{table}";
                string command = "EXEC " + sp;
                _dbSet.FromSqlRaw(command).ToList();
            }
            catch (Exception e)
            {

            }

        }
        public void DeleteAll()
        {
            _dbSet.RemoveRange(_dbSet);
            _context.SaveChanges();
        }
    }
}
