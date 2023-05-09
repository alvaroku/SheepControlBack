using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class VaccineSheepBusiness : IVaccineSheepBusiness
    {
        VaccineSheepRepository _VaccineSheepRepository;
        SheepRepository _SheepRepository;
        VaccineRepository _VaccineRepository;
        public VaccineSheepBusiness(SheepControlDbContext context)
        {
            _VaccineSheepRepository = new VaccineSheepRepository(context);
            _SheepRepository = new SheepRepository(context);
            _VaccineRepository = new VaccineRepository(context);
        }
        public Response<VaccineSheepResponse> Create(VaccineSheepRequest request)
        {
            Response<VaccineSheepResponse> response = new Response<VaccineSheepResponse>();

            try
            {
                VaccineSheep newData = Mapper.Map<VaccineSheep>(request);

                newData.CreationDate = DateTime.Now;
                newData.ModificationDate = newData.CreationDate;
                newData.Active = true;

                _VaccineSheepRepository.Create(newData);

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
        public Response< IEnumerable<VaccineSheepResponse>> ApplyVaccineToAllSheeps(VaccineSheepRequest request)
        {
            Response<IEnumerable<VaccineSheepResponse>> response = new Response<IEnumerable<VaccineSheepResponse>>();
            IEnumerable<Sheep> allSheeps = _SheepRepository.Read();
            Vaccine vaccineToApply = _VaccineRepository.GetById(request.VaccineId);
            List<VaccineSheep> dataToInsert = new List<VaccineSheep>();

            foreach (Sheep item in allSheeps)
            {
                VaccineSheep newData = new VaccineSheep
                {
                    SheepId = item.Id,
                    VaccineId = request.VaccineId,
                    ApplicationDate = request.ApplicationDate,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DoseApplied = Utils.Utils.CalculateDoseRecomended(vaccineToApply.IndicatedDose, item.Weight),
                    Active = true

                };
                dataToInsert.Add(newData);
            }
            _VaccineSheepRepository.CreateRange(dataToInsert);
           
            response.Data =  Mapper.Map<IEnumerable<VaccineSheepResponse>>(dataToInsert);
            response.Message = $"Se agregó la vacuna {vaccineToApply.Name} a {dataToInsert.Count} carneros.";
            return response;
        }

        public Response<VaccineSheepResponse> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VaccineSheepResponse> Read()
        {
            var respuesta = _VaccineSheepRepository.Read();

            var mapeo = Mapper.Map<IEnumerable<VaccineSheepResponse>>(respuesta);

            return mapeo.ToList();
        }
        public IEnumerable<VaccineSheepResponse> ReadIncludes()
        {
            var respuesta = _VaccineSheepRepository.ReadIncludes();

            var mapeo = Mapper.Map<IEnumerable<VaccineSheepResponse>>(respuesta);
            
            return mapeo.ToList();
        }
        public IEnumerable<VaccineSheepResponse> ReadIncludesWithFilters(FilterVaccineSheepRequest request)
        {
            var dataFiltered = _VaccineSheepRepository.ReadIncludes();
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

            VaccineSheep vaccineSheep = _VaccineSheepRepository.GetByIdIncludes(id);

            vaccineSheep.ModificationDate = DateTime.Now;
            vaccineSheep.ApplicationDate = request.ApplicationDate;
            vaccineSheep.DoseApplied = request.DoseApplied;

            _VaccineSheepRepository.Update(vaccineSheep);

            response.Data = Mapper.Map<VaccineSheepResponse>(vaccineSheep);

            return response;
        }
        public Response<bool> Delete(int id)
        {
            Response<bool> response = new Response<bool>();
            VaccineSheep sh = _VaccineSheepRepository.GetById(id);
            _VaccineSheepRepository.Delete(sh);
            return response;
        }
        public Response<bool> DeleteAll()
        {
            Response<bool> response = new Response<bool>();
            response.Message = $"Se eliminaron {_VaccineSheepRepository._dbSet.Count()} registros";
            response.Data = true;
            _VaccineSheepRepository.DeleteAll();
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
