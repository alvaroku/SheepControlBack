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
        Task< Response<VaccineStockResponse>> Create(VaccineStockRequest controllerRequest);

        Task< Response<IEnumerable<VaccineStockResponse>>> Read();
        Task< Response<VaccineStockResponse>> Update(int id, VaccineStockRequest request);
        Task< Response<bool>> Delete(int id);
        Task< Response<bool>> ToggleActive(int id);
    }
}
