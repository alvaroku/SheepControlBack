using Entities;
using Entities.DTOs;

namespace DataAccess.Implementations
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(SheepControlDbContext context) : base(context)
        {
            
        }
        //pasar la logica a Business
        public User Login(LoginRequest loginRequest)
        {
            User result = _dbSet.Where(x => (x.Active && x.Email == loginRequest.Email && x.Password == loginRequest.Password)).FirstOrDefault();
            return result;
        }
        public User GetByEmail(string email)
        {
            return _dbSet.Where(z => z.Email == email).FirstOrDefault();
        }
    }
}
