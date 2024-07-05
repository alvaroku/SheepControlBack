using AutoMapper;
using Business.Definitions;
using DataAccess.Repositories.Definitions;
using Entities;
using Entities.DTOs;
using OfficeOpenXml;
using Shared;

namespace Business.Implementations
{
    public class VaccineSheepBusiness : IVaccineSheepBusiness
    {
        IVaccineSheepRepository _Repository;
        ISheepRepository _SheepRepository;
        IVaccineRepository _VaccineRepository;
        ISheepHistoricWeightRepository _HistoricWeightRepository;
        public VaccineSheepBusiness(IVaccineSheepRepository vaccineSheepRepository, ISheepRepository sheepRepository, ISheepHistoricWeightRepository sheepHistoricWeightRepository, IVaccineRepository vaccineRepository)
        {
            _Repository = vaccineSheepRepository;
            _SheepRepository = sheepRepository;
            _VaccineRepository = vaccineRepository;
            _HistoricWeightRepository = sheepHistoricWeightRepository;
        }
        public async Task<Response<VaccineSheepResponse>> Create(VaccineSheepRequest request)
        {
            Response<VaccineSheepResponse> response = new Response<VaccineSheepResponse>();

            try
            {
                VaccineSheep newData = Mapper.Map<VaccineSheep>(request);

                Vaccine v = await _VaccineRepository.GetById(request.VaccineId);
                Sheep s = await _SheepRepository.GetById(request.SheepId);

                newData.CreationDate = DateTime.Now;
                newData.ModificationDate = newData.CreationDate;
                newData.Active = true;
                newData.DoseApplied = Utilities.CalculateDoseRecomended(v.IndicatedDose, s.Weight);
                await _Repository.Add(newData);

                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == newData.SheepId).Count() > 0)
                {
                    newData.Sheep.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == newData.SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
                response.Message = MessageConstants.CreateSuccesMessage;
                response.Data = Mapper.Map<VaccineSheepResponse>(newData);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
            }

            return response;
        }
        public async Task<Response<IEnumerable<VaccineSheepResponse>>> ApplyVaccineToAllSheeps(VaccineSheepVaccineToAllRequest request)
        {
            Response<IEnumerable<VaccineSheepResponse>> response = new Response<IEnumerable<VaccineSheepResponse>>();

            Vaccine vaccineToApply = await _VaccineRepository.GetById(request.VaccineId);
            List<VaccineSheep> dataToInsert = new List<VaccineSheep>();

            foreach (int sheepId in request.SheepIds)
            {
                float WeighingDayWeight = 0;
                Sheep sheep = await _SheepRepository.GetById(sheepId);
                WeighingDayWeight = sheep.Weight;
                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == sheepId).Count() > 0)
                {
                    sheep.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == sheep.Id).OrderByDescending(x => x.Id).First().NewWeight;
                    WeighingDayWeight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == sheep.Id).OrderByDescending(x => x.Id).First().NewWeight;
                }
                VaccineSheep newData = new VaccineSheep
                {
                    SheepId = sheepId,
                    VaccineId = request.VaccineId,
                    ApplicationDate = request.ApplicationDate,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DoseApplied = Utilities.CalculateDoseRecomended(vaccineToApply.IndicatedDose, sheep.Weight),
                    Active = true,
                    WeightVaccinationDay = WeighingDayWeight
                };
                dataToInsert.Add(newData);
            }
            await _Repository.CreateRange(dataToInsert);

            for (int i = 0; i < dataToInsert.Count(); i++)
            {
                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == dataToInsert[i].SheepId).Count() > 0)
                {
                    dataToInsert[i].Sheep.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == dataToInsert[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            response.Data = Mapper.Map<IEnumerable<VaccineSheepResponse>>(dataToInsert);
            response.Message = $"Se agregó la vacuna {vaccineToApply.Name} a {dataToInsert.Count} carneros.";
            return response;
        }

        public async Task<Response<VaccineSheepResponse>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VaccineSheepResponse>> Read()
        {
            var respuesta = _Repository.GetAll().Result.ToList();

            var mapeo = Mapper.Map<IEnumerable<VaccineSheepResponse>>(respuesta);

            return mapeo.ToList();
        }
        public async Task<IEnumerable<VaccineSheepResponse>> ReadIncludes()
        {
            var respuesta = _Repository.ReadIncludes().Result.ToList();

            for (int i = 0; i < respuesta.Count(); i++)
            {
                if (_HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == respuesta[i].SheepId).Count() > 0)
                {
                    respuesta[i].Sheep.Weight = _HistoricWeightRepository.GetAll().Result.Where(x => x.SheepId == respuesta[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            var mapeo = Mapper.Map<IEnumerable<VaccineSheepResponse>>(respuesta);

            return mapeo.ToList().OrderBy(x => x.Id).OrderBy(x => x.SheepId); ;
        }
        public async Task<IEnumerable<VaccineSheepResponse>> ReadIncludesWithFilters(FilterVaccineSheepRequest request)
        {
            var dataFiltered = await _Repository.ReadIncludes();
            dataFiltered = dataFiltered.Where(vs => vs.ApplicationDate >= request.StartDate && vs.ApplicationDate <= request.FinishDate);
            if (request.SheepId > 0)
            {
                dataFiltered = dataFiltered.Where(vs => vs.SheepId == request.SheepId);
            }
            if (request.VaccineId > 0)
            {
                dataFiltered = dataFiltered.Where(vs => vs.VaccineId == request.VaccineId);
            }

            var mapeo = Mapper.Map<IEnumerable<VaccineSheepResponse>>(dataFiltered);

            return mapeo.ToList();
        }
        public async Task<Response<VaccineSheepResponse>> Update(int id, VaccineSheepRequest request)
        {
            Response<VaccineSheepResponse> response = new Response<VaccineSheepResponse>();

            VaccineSheep vaccineSheep = await _Repository.GetByIdIncludes(id);

            vaccineSheep.ModificationDate = DateTime.Now;
            vaccineSheep.ApplicationDate = request.ApplicationDate;
            vaccineSheep.DoseApplied = request.DoseApplied;

            await _Repository.Update(vaccineSheep);
            response.Message = MessageConstants.UpdateSuccesMessage;
            response.Data = Mapper.Map<VaccineSheepResponse>(vaccineSheep);

            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            VaccineSheep sh = await _Repository.GetById(id);
            await _Repository.Delete(sh.Id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> DeleteAll()
        {
            Response<bool> response = new Response<bool>();
            response.Message = $"Se eliminaron {_Repository.GetAll().Result.Count()} registros";
            response.Data = true;
            _Repository.DeleteAll();
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            return response;
        }
        public async Task<Response<ReportResponse>> GenerateReport()
        {
            Response<ReportResponse> response = new Response<ReportResponse>();
            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            var miLista = new List<UserResponse> { new UserResponse { Name = "alvaro", LastName = "Ku", Email = "alvaro@gmail.com" } };

            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.Add("Datos");
                worksheet.Cells["A1"].Value = "Hola";
                // Escribir datos en la hoja de cálculo
                var range = worksheet.Cells["A1:C1"];
                range.LoadFromArrays(miLista.Select(obj => new object[] { obj.Name, obj.LastName, obj.Email }).ToArray());
                package.Save();
            }
            stream.Position = 0;
            ReportResponse r = new ReportResponse { Excel = stream };
            response.Data = r;
            return response;
        }
    }
}
