using Entities;
using Entities.DTOs;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(SheepControlDbContext context) : base(context)
        {
            
        }
        public User Login(LoginRequest loginRequest)
        {
            User result = _dbSet.Where(x => (x.Active && x.Email == loginRequest.Email && x.Password == loginRequest.Password)).FirstOrDefault();
            return result;
        }
    }
}
