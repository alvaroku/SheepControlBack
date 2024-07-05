using Entities.DTOs;

namespace Business.Definitions
{
    public interface ISaleSheepBusiness
    {
         Task<Response<SaleSheepResponse>> Create(SaleSheepRequest SaleSheepRequest);
         Task<Response<IEnumerable<SaleSheepResponse>>> CreateMultiple(SaleMultipleSheepRequest SaleSheepRequest);
         Task<Response<IEnumerable<SaleSheepResponse>>> Read();
         Task<Response<IEnumerable<SaleSheepResponse>>> ReadWithFilters(FilterSaleSheepRequest request);
         Task<Response<SaleSheepResponse>> Update(int id, SaleSheepRequest request);
         Task<Response<bool>> Delete(int id);
         Task<Response<bool>> ToggleActive(int id);
    }
}
