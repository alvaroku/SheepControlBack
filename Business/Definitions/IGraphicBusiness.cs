using Entities.DTOs;

namespace Business.Definitions
{
    public interface IGraphicBusiness
    {
        Task<Response<DataGraphicSheepPurchaseExpenseProfitsResponse>> GetDataGraphicSheepPurchaseExpenseProfits();
    }
}
