using Entities.DTOs;

namespace Entities.DTOs
{
    public class UserRequest : ObjetoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class UserResponse : ObjetoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

    }
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class LoginResponse
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get;set; }
    }
}
