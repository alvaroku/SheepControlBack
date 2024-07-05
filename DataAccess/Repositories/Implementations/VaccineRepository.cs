using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Generic;
using Entities;

namespace DataAccess.Repositories.Implementations
{
    public class VaccineRepository : GenericRepository<Vaccine>,IVaccineRepository
    {
        public VaccineRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
