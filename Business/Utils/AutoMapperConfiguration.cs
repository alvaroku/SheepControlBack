using AutoMapper;
using Entities;
using Entities.DTOs;

namespace Business.Utils
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //mappers principales

                cfg.CreateMap<User, UserResponse>().ReverseMap();
                cfg.CreateMap<User, LoginResponse>().ReverseMap();
                cfg.CreateMap<VaccineSheepRequest,VaccineSheep >().ReverseMap();
                cfg.CreateMap<Permission, PermissionRequest>().ReverseMap();
                cfg.CreateMap<PermissionRole,PermissionRoleRequest>().ReverseMap();
                cfg.CreateMap<RoleUser, RoleUserRequest>().ReverseMap();
                cfg.CreateMap<SheepHistoricWeightRequest, SheepHistoricWeight>().ReverseMap();
                cfg.CreateMap<VaccineStockRequest, VaccineStock>().ReverseMap();
            });
        }
    }
}
