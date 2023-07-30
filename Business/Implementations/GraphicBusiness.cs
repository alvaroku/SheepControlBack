using Business.Definitions;
using DataAccess.Implementations;
using DataAccess;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class GraphicBusiness : IGraphicBusiness
    {
        SaleSheepRepository _Repository;
        public GraphicBusiness(SheepControlDbContext context)
        {

            _Repository = new SaleSheepRepository(context);
        }
        public Response<DataGraphicSheepPurchaseExpenseProfitsResponse> GetDataGraphicSheepPurchaseExpenseProfits()
        {
            //obtener cuado gaste en las compras de careros
            float totalGastoCompra = _Repository._context.Sheeps.Where(x => x.IsAcquisition).Sum(y => y.AcquisitionCost);
            //obtener la suma de las ganancias
            float profits = _Repository.ReadIncludes().Sum(x=>x.SaleProfit);

            Response<DataGraphicSheepPurchaseExpenseProfitsResponse> response = new Response<DataGraphicSheepPurchaseExpenseProfitsResponse>();
            response.Data = new DataGraphicSheepPurchaseExpenseProfitsResponse { PurchaseExpense = totalGastoCompra, Profits = profits };
            return response;
        }
    }
}
