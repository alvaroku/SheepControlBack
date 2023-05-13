using Entities.DTOs;

namespace Business.Definitions
{
    public interface IActionBusiness
    {
        public Response<ActionResponse> Create(ActionRequest actionRequest);
        public IEnumerable<ActionResponse> Read();
        public Response<ActionResponse> Update(int id, ActionRequest request);
        public Response<bool> Delete(int id);
    }
}
