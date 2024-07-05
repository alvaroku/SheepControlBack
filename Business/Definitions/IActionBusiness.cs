using Entities.DTOs;

namespace Business.Definitions
{
    public interface IActionBusiness
    {
        Task<Response<ActionResponse>> Create(ActionRequest actionRequest);
        Task<IEnumerable<ActionResponse>> Read();
        Task<Response<ActionResponse>> Update(int id, ActionRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
    }
}
