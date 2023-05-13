using Entities.DTOs;

namespace Business.Definitions
{
    public interface IControllerBusiness
    {
        public Response<ControllerResponse> Create(ControllerRequest controllerRequest);
        public IEnumerable<ControllerResponse> Read();
        public Response<ControllerResponse> Update(int id, ControllerRequest request);
        public Response<bool> Delete(int id);
    }
}
