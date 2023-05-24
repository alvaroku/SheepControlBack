using Entities.DTOs;

namespace Business.Definitions
{
    public interface ISaleSheepBusiness
    {
        public Response<SaleSheepResponse> Create(SaleSheepRequest SaleSheepRequest);
        public Response<IEnumerable<SaleSheepResponse>> CreateMultiple(SaleMultipleSheepRequest SaleSheepRequest);
        public Response<IEnumerable<SaleSheepResponse>> Read();
        public Response<IEnumerable<SaleSheepResponse>> ReadWithFilters(FilterSaleSheepRequest request);
        public Response<SaleSheepResponse> Update(int id, SaleSheepRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
    }
}
