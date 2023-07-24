namespace Entities.DTOs
{
    public class RoleUserRequest : ObjetoBase
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
    public class RoleUserRequestCreateRequest
    {
        public int UserId { get; set; }
        public int[] RoleIds { get; set; }
    }
    public class RoleUserResponse : ObjetoBase
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
