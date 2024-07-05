using Entities.DTOs;

namespace Business.Definitions
{
    public interface ISheepHistoricWeightBusiness
    {
        Task<Response<IEnumerable<SheepHistoricWeightResponse>>> Read();
        Task<Response<SheepHistoricWeightResponse>> Create(SheepHistoricWeightRequest request);
        Task<Response<SheepHistoricWeightResponse>> Update(int id, SheepHistoricWeightRequest request);
        Task<Response<bool>> Delete(int id);
        Task<Response<bool>> ToggleActive(int id);
    }
}
