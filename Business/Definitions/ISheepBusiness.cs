using Entities.DTOs;

namespace Business.Definitions
{
    public interface ISheepBusiness
    {
        Task<Response<SheepResponse>> Create(SheepRequest sheepRequest);
        Task<IEnumerable<SheepResponse>> Read();
        Task<IEnumerable<SheepResponse>> GetSheepsWithFinalWeight();
        Task<Response<SheepResponse>> GetById(int id);
        Task<Response<SheepResponse>> Update(int id, SheepRequest sheepRequest);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
        FileStream GetImage(string imageName);
    }
}
