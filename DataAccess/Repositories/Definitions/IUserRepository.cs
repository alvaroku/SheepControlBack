using Entities.DTOs;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface IUserRepository
    {
        Task<User> Login(LoginRequest loginRequest);

        Task<User> GetByEmail(string email);
    }
}
