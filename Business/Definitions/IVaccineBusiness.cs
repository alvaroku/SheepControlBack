using Entities.DTOs;

namespace Business.Definitions
{
    public interface IVaccineBusiness
    {
        Task<Response<VaccineResponse>> Create(VaccineRequest vaccineRequest);
        Task<IEnumerable<VaccineResponse>> Read();
        Task<Response<VaccineResponse>> Update(int id, VaccineUpdateRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<VaccineResponse>> GetById(int id);
        Task<Response<bool>> ToggleActive(int id);
        FileStream GetImage(string imageName);
    }
}
