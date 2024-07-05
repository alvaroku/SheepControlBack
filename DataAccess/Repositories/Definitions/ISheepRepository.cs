using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Definitions
{
    public interface ISheepRepository:IGenericRepository<Sheep>
    {
        Task<float> GetGastoCompra();
    }
}
