using Entities.DTOs;

namespace Business.Definitions
{
    public interface IVaccineSheepBusiness
    {
         Task<Response<VaccineSheepResponse>> Create(VaccineSheepRequest request);
         Task<IEnumerable<VaccineSheepResponse>> Read();
        Task< Response<IEnumerable<VaccineSheepResponse>>> ApplyVaccineToAllSheeps(VaccineSheepVaccineToAllRequest request);
         Task<IEnumerable<VaccineSheepResponse>> ReadIncludes();
         Task<IEnumerable<VaccineSheepResponse>> ReadIncludesWithFilters(FilterVaccineSheepRequest request);
        Task<Response<VaccineSheepResponse>> Update(int id, VaccineSheepRequest request);
         Task<Response<bool>> Delete(int id);
         Task<Response<bool>> DeleteAll();
        Task< Response<VaccineSheepResponse>> GetById(int id);
         Task<Response<ReportResponse>> GenerateReport();
         Task<Response<bool>>ToggleActive(int id);
    }
}
