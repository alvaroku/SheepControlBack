using DataAccess.Repositories.Definitions;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SheepControlDbContext context) : base(context)
        {

        }

        public async Task<User> Login(LoginRequest loginRequest)
        {
            User result = await _dbSet.Where(x => x.Active && x.Email == loginRequest.Email && x.Password == loginRequest.Password).FirstOrDefaultAsync();
            return result;
        }
        public async Task<User> GetByEmail(string email)
        {
            return await _dbSet.Where(z => z.Email == email).FirstOrDefaultAsync();
        }
    }
}
