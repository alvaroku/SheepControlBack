using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IVaccineBusiness
    {
        public Response<VaccineResponse> Create(VaccineRequest vaccineRequest);
        public IEnumerable<VaccineResponse> Read();
    }
}
