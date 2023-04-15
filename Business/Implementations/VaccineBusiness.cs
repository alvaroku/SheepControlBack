using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class VaccineBusiness:IVaccineBusiness
    {
        VaccineRepository _VaccineRepository;
        public VaccineBusiness(SheepControlDbContext context)
        {
            _VaccineRepository = new VaccineRepository(context);
        }

        public Response<VaccineResponse> Create(VaccineRequest vaccineRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VaccineResponse> Read()
        {
            throw new NotImplementedException();
        }
    }
}
