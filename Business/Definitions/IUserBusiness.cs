using Entities.DTOs;

namespace Business.Definitions
{
    public interface IUserBusiness
    {
        public Response<UserResponse> Create(UserRequest userRequest);
        public IEnumerable<UserResponse> Read();
        public Response<UserResponse> Update(int id, UserRequest request);
        public Response<bool> Delete(int id);
    }
}
