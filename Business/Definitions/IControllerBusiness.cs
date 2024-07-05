using Entities.DTOs;

namespace Business.Definitions
{
    public interface IControllerBusiness
    {
        Task<Response<ControllerResponse>> Create(ControllerRequest controllerRequest);
        Task<IEnumerable<ControllerResponse>> Read();
        Task<Response<ControllerResponse>>  Update(int id, ControllerRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
    }
}
