using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IVaccineSheepBusiness
    {
        public Response<VaccineSheepResponse> Create(VaccineSheepRequest request);
        public IEnumerable<VaccineSheepResponse> Read();
        public Response<IEnumerable<VaccineSheepResponse>> ApplyVaccineToAllSheeps(VaccineSheepRequest request);
        public IEnumerable<VaccineSheepResponse> ReadIncludes();
        public IEnumerable<VaccineSheepResponse> ReadIncludesWithFilters(FilterVaccineSheepRequest request);
        public Response<VaccineSheepResponse> Update(int id, VaccineSheepRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> DeleteAll();
        public Response<VaccineSheepResponse> GetById(int id);
        public Response<ReportResponse> GenerateReport();
    }
}
