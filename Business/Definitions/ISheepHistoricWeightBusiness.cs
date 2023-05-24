using Entities;
using Entities.DTOs;

namespace Business.Definitions
{
    public interface ISheepHistoricWeightBusiness
    {
        public Response<IEnumerable<SheepHistoricWeightResponse>> Read();
        public Response<SheepHistoricWeightResponse> Create(SheepHistoricWeightRequest request);
        public Response<SheepHistoricWeightResponse> Update(int id, SheepHistoricWeightRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
    }
}
