
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Update(T Data)
        {
            _dbSet.Update(Data);
            _context.SaveChanges();
        }
        public void Delete(T Data)
        {
            _dbSet.Remove(Data);
            _context.SaveChanges();
        }
        public void DeleteAll()
        {
            _dbSet.RemoveRange(_dbSet);
            _context.SaveChanges();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
