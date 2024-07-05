using Business.Definitions;
using DataAccess;
using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Implementations;
using Entities.DTOs;

namespace Business.Implementations
{
    public class GraphicBusiness : IGraphicBusiness
    {
        ISaleSheepRepository _Repository;
        ISheepRepository _SheepRepository;
        public GraphicBusiness(ISaleSheepRepository saleSheepRepository, ISheepRepository sheepRepository)
        {
            _Repository = saleSheepRepository;
            _SheepRepository = sheepRepository;
        }
        public async Task<Response<DataGraphicSheepPurchaseExpenseProfitsResponse>> GetDataGraphicSheepPurchaseExpenseProfits()
        {
            //obtener cuado gaste en las compras de careros
            float totalGastoCompra = await _SheepRepository.GetGastoCompra();
            //obtener la suma de las ganancias
            float profits = await _Repository.GetGanancias();

            Response<DataGraphicSheepPurchaseExpenseProfitsResponse> response = new Response<DataGraphicSheepPurchaseExpenseProfitsResponse>();
            response.Data = new DataGraphicSheepPurchaseExpenseProfitsResponse { PurchaseExpense = totalGastoCompra, Profits = profits };
            return response;
        }
    }
}
