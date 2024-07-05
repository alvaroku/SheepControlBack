using Entities.DTOs;
using Entities;
using DataAccess.Repositories.Generic;

namespace DataAccess.Repositories.Definitions
{
    public interface IUserRepository:IGenericRepository<User>
    {
        Task<User> Login(LoginRequest loginRequest);

        Task<User> GetByEmail(string email);
    }
}
