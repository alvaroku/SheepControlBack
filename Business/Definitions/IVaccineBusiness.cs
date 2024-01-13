using Entities.DTOs;

namespace Business.Definitions
{
    public interface IVaccineBusiness
    {
        public Response<VaccineResponse> Create(VaccineRequest vaccineRequest);
        public IEnumerable<VaccineResponse> Read();
        public Response<VaccineResponse> Update(int id, VaccineUpdateRequest request);
        public Response<bool> Delete(int id);
        public Response<VaccineResponse> GetById(int id);
        public Response<bool> ToggleActive(int id);
        FileStream GetImage(string imageName);
    }
}
