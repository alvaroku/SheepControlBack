using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using OfficeOpenXml;

namespace Business.Implementations
{
    public class VaccineSheepBusiness : IVaccineSheepBusiness
    {
        VaccineSheepRepository _Repository;
        SheepRepository _SheepRepository;
        VaccineRepository _VaccineRepository;
        SheepHistoricWeightRepository _HistoricWeightRepository;
        public VaccineSheepBusiness(SheepControlDbContext context)
        {
            _Repository = new VaccineSheepRepository(context);
            _SheepRepository = new SheepRepository(context);
            _VaccineRepository = new VaccineRepository(context);
            _HistoricWeightRepository = new SheepHistoricWeightRepository(context);
        }
        public Response<VaccineSheepResponse> Create(VaccineSheepRequest request)
        {
            Response<VaccineSheepResponse> response = new Response<VaccineSheepResponse>();

            try
            {
                VaccineSheep newData = Mapper.Map<VaccineSheep>(request);

                Vaccine v = _VaccineRepository.GetById(request.VaccineId);
                Sheep s = _SheepRepository.GetById(request.SheepId);

                newData.CreationDate = DateTime.Now;
                newData.ModificationDate = newData.CreationDate;
                newData.Active = true;
                newData.DoseApplied = Utils.Utils.CalculateDoseRecomended(v.IndicatedDose, s.Weight);
                _Repository.Create(newData);

                if (_HistoricWeightRepository.Read().Where(x => x.SheepId == newData.SheepId).Count() > 0)
                {
                    newData.Sheep.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == newData.SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
                response.Message = Constants.CreateSuccesMessage;
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
        public Response<IEnumerable<VaccineSheepResponse>> ApplyVaccineToAllSheeps(VaccineSheepVaccineToAllRequest request)
        {
            Response<IEnumerable<VaccineSheepResponse>> response = new Response<IEnumerable<VaccineSheepResponse>>();

            Vaccine vaccineToApply = _VaccineRepository.GetById(request.VaccineId);
            List<VaccineSheep> dataToInsert = new List<VaccineSheep>();

            foreach (int sheepId in request.SheepIds)
            {
                float WeighingDayWeight = 0;
                Sheep sheep = _SheepRepository.GetById(sheepId);
                WeighingDayWeight = sheep.Weight;
                if (_HistoricWeightRepository.Read().Where(x => x.SheepId == sheepId).Count() > 0)
                {
                    sheep.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == sheep.Id).OrderByDescending(x => x.Id).First().NewWeight;
                    WeighingDayWeight = _HistoricWeightRepository.Read().Where(x => x.SheepId == sheep.Id).OrderByDescending(x => x.Id).First().NewWeight;
                }
                VaccineSheep newData = new VaccineSheep
                {
                    SheepId = sheepId,
                    VaccineId = request.VaccineId,
                    ApplicationDate = request.ApplicationDate,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DoseApplied = Utils.Utils.CalculateDoseRecomended(vaccineToApply.IndicatedDose, sheep.Weight),
                    Active = true,
                    WeightVaccinationDay = WeighingDayWeight
                };
                dataToInsert.Add(newData);
            }
            _Repository.CreateRange(dataToInsert);

            for (int i = 0; i < dataToInsert.Count(); i++)
            {
                if (_HistoricWeightRepository.Read().Where(x => x.SheepId == dataToInsert[i].SheepId).Count() > 0)
                {
                    dataToInsert[i].Sheep.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == dataToInsert[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            response.Data = Mapper.Map<IEnumerable<VaccineSheepResponse>>(dataToInsert);
            response.Message = $"Se agregó la vacuna {vaccineToApply.Name} a {dataToInsert.Count} carneros.";
            return response;
        }

        public Response<VaccineSheepResponse> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VaccineSheepResponse> Read()
        {
            var respuesta = _Repository.Read().ToList();



            var mapeo = Mapper.Map<IEnumerable<VaccineSheepResponse>>(respuesta);

            return mapeo.ToList();
        }
        public IEnumerable<VaccineSheepResponse> ReadIncludes()
        {
            var respuesta = _Repository.ReadIncludes().ToList();

            for (int i = 0; i < respuesta.Count(); i++)
            {
                if (_HistoricWeightRepository.Read().Where(x => x.SheepId == respuesta[i].SheepId).Count() > 0)
                {
                    respuesta[i].Sheep.Weight = _HistoricWeightRepository.Read().Where(x => x.SheepId == respuesta[i].SheepId).OrderByDescending(x => x.Id).First().NewWeight;
                }
            }

            var mapeo = Mapper.Map<IEnumerable<VaccineSheepResponse>>(respuesta);

            return mapeo.ToList().OrderBy(x => x.Id).OrderBy(x => x.SheepId); ;
        }
        public IEnumerable<VaccineSheepResponse> ReadIncludesWithFilters(FilterVaccineSheepRequest request)
        {
            var dataFiltered = _Repository.ReadIncludes();
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
        public Response<VaccineSheepResponse> Update(int id, VaccineSheepRequest request)
        {
            Response<VaccineSheepResponse> response = new Response<VaccineSheepResponse>();

            VaccineSheep vaccineSheep = _Repository.GetByIdIncludes(id);

            vaccineSheep.ModificationDate = DateTime.Now;
            vaccineSheep.ApplicationDate = request.ApplicationDate;
            vaccineSheep.DoseApplied = request.DoseApplied;

            _Repository.Update(vaccineSheep);
            response.Message = Constants.UpdateSuccesMessage;
            response.Data = Mapper.Map<VaccineSheepResponse>(vaccineSheep);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            VaccineSheep sh = _Repository.GetById(id);
            _Repository.Delete(sh);
            response.Message = Constants.DeleteSuccesMessage;
            return response;
        }
        public Response<bool> DeleteAll()
        {
            Response<bool> response = new Response<bool>();
            response.Message = $"Se eliminaron {_Repository._dbSet.Count()} registros";
            response.Data = true;
            _Repository.DeleteAll();
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
            response.Data = data.Active;
            response.Message = data.Active ? Constants.ActiveSuccesMessage : Constants.InactiveSuccesMessage;
            return response;
        }
        public Response<ReportResponse> GenerateReport()
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
