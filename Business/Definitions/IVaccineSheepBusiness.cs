using Entities.DTOs;

namespace Business.Definitions
{
    public interface IVaccineSheepBusiness
    {
        public Response<VaccineSheepResponse> Create(VaccineSheepRequest request);
        public IEnumerable<VaccineSheepResponse> Read();
        public Response<IEnumerable<VaccineSheepResponse>> ApplyVaccineToAllSheeps(VaccineSheepVaccineToAllRequest request);
        public IEnumerable<VaccineSheepResponse> ReadIncludes();
        public IEnumerable<VaccineSheepResponse> ReadIncludesWithFilters(FilterVaccineSheepRequest request);
        public Response<VaccineSheepResponse> Update(int id, VaccineSheepRequest request);
        public Response<bool> Delete(int id);
        public Response<bool> DeleteAll();
        public Response<VaccineSheepResponse> GetById(int id);
        public Response<ReportResponse> GenerateReport();
        public Response<bool> ToggleActive(int id);
    }
}
