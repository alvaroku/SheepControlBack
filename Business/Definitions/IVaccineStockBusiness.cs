using AutoMapper;
using Entities.DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IVaccineStockBusiness
    {
        public Response<VaccineStockResponse> Create(VaccineStockRequest controllerRequest);

        public Response<IEnumerable<VaccineStockResponse>> Read();
        public Response<VaccineStockResponse> Update(int id, VaccineStockRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> ToggleActive(int id);
    }
}
